﻿using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Models.Model;
using static BaseNetCoreApi.Helper.ConfigurationHelper;

namespace BaseNetCoreApi.BackgroundTask
{
    public class TimedHostedService : IHostedService, IDisposable
    {
        private readonly ILogger<TimedHostedService> _logger;
        private Timer? _timer = null;
        private Dictionary<string, List<TimeSpan>> TaskTimed = new Dictionary<string, List<TimeSpan>>();

        private ICommonBackgroundTaskQueue _CommonBackgroundTaskQueue;
        public TimedHostedService(ILogger<TimedHostedService> logger, ICommonBackgroundTaskQueue CommonBackgroundTaskQueue)
        {
            _logger = logger;
            _CommonBackgroundTaskQueue = CommonBackgroundTaskQueue;
        }

        public Task StartAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service running.");

            _timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(5));

            return Task.CompletedTask;
        }

        private void DoWork(object? state)
        {
            var now = DateTime.Now.TimeOfDay;
            if (IsActiveTime(now, TimedService.CLEAR_EXPERIED_REFRESHTOKEN_CONFIG_NAME))
            {
                _CommonBackgroundTaskQueue.QueueBackgroundWorkItem(new ClearExpRfTokenTask());
            }
            else if (IsActiveTime(now, TimedService.CLEAR_TEMP_FILE_CONFIG_NAME))
            {
                _CommonBackgroundTaskQueue.QueueBackgroundWorkItem(new ClearTempFileTask());
            }
        }

        public Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Timed Hosted Service is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }

        public List<TimeSpan> GetActiveTime(string configName)
        {
            List<TimeSpan>? result = new List<TimeSpan>();
            if (!TaskTimed.TryGetValue(configName, out result))
            {
                result = new List<TimeSpan>();
                var lstTimed = Configuration.GetSection(TimedService.TIMED_SERVICE_CONFIG_NAME + configName)
                    .GetChildren().Select(s => s.Value?.ToString()).ToList() ?? new List<string?>();
                lstTimed.ForEach(timed =>
                {
                    var timeSpan = TimeSpan.ParseExact(timed ?? "", "hh':'ss", null);
                    result.Add(timeSpan);
                });
                TaskTimed.Add(configName,result);
            }
            return result;
        }
        public bool IsActiveTime(TimeSpan now, string configName)
        {
            return GetActiveTime(configName).Any(a => a.Hours == now.Hours && a.Minutes == now.Minutes);
        }
    }
}
