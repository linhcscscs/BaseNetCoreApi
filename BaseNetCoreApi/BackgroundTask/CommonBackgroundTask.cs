using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Models.Model;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Services.Interface;
using System.Threading.Channels;

namespace BaseNetCoreApi.BackgroundTask
{
    #region Queue
    public interface ICommonBackgroundTaskQueue : IBackgroundTaskQueue<HostedServiceTask>
    {

    }
    public class CommonBackgroundTaskQueue : BackgroundTaskQueue<HostedServiceTask>, ICommonBackgroundTaskQueue
    {
    }
    #endregion
    public class CommonBackgroundTaskBackgroundService : BackgroundService
    {
        private IAuthenticateService _authenticateService;
        private ICommonBackgroundTaskQueue _CommonBackgroundTaskQueue;
        private ILogger<CommonBackgroundTaskBackgroundService> _logger;
        private IServiceProvider _serviceProvider;
        public CommonBackgroundTaskBackgroundService(ICommonBackgroundTaskQueue CommonBackgroundTaskQueue, ILogger<CommonBackgroundTaskBackgroundService> logger, IServiceProvider serviceProvider)
        {
            _CommonBackgroundTaskQueue = CommonBackgroundTaskQueue;
            _logger = logger;
            _serviceProvider = serviceProvider;
        }
        private double FileExpInMinutes = ConfigurationHelper.TempFileExpInMinutes;
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await DoWork(stoppingToken);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex,
                        "CommonBackgroundTask ex",
                        new
                        {
                            token = stoppingToken,
                            ex = ex
                        });
                }
            }
        }
        protected async Task DoWork(CancellationToken stoppingToken)
        {
            var workItem = await _CommonBackgroundTaskQueue.DequeueAsync(stoppingToken);
            switch (workItem.EHostedServiceTask)
            {
                case EHostedServiceTask.ClearExpRefreshToken:
                    ClearRefreshToken();
                    break;
                case EHostedServiceTask.ClearTempFile:
                    ClearTempFile();
                    break;
                default:
                    break;
            }
        }

        protected void ClearRefreshToken()
        {
            if (_authenticateService == null)
            {
                _authenticateService = _serviceProvider.CreateScope().ServiceProvider.GetRequiredService<IAuthenticateService>();
            }
            _authenticateService.ClearRefreshToken();
        }

        protected void ClearTempFile()
        {
            DirectoryInfo folder = new DirectoryInfo(ConfigurationHelper.FileFolerInternalURL + "/Temp");
            var files = folder.GetFiles();
            var expTime = DateTime.Now.AddMinutes(-FileExpInMinutes);
            foreach (var file in files)
            {
                if (file.CreationTime < expTime)
                {
                    try
                    {
                        if (File.Exists(file.FullName))
                        {
                            File.Delete(file.FullName);
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
