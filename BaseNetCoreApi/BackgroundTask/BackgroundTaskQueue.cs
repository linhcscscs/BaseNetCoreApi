using System.Collections.Concurrent;
using System.Threading.Channels;

namespace BaseNetCoreApi.BackgroundTask
{
    public interface IBackgroundTaskQueue<T>
    {
        void QueueBackgroundWorkItem(T Data);

        Task<T> DequeueAsync(CancellationToken cancellationToken);
    }

    public class BackgroundTaskQueue<T> : IBackgroundTaskQueue<T>
    {
        private ConcurrentQueue<T> _workItems = new ConcurrentQueue<T>();
        private SemaphoreSlim _signal = new SemaphoreSlim(0);
        public BackgroundTaskQueue()
        {
        }
        public async Task<T> DequeueAsync(CancellationToken cancellationToken)
        {
            await _signal.WaitAsync(cancellationToken);
            _workItems.TryDequeue(out var workItem);
            return workItem;
        }

        public void QueueBackgroundWorkItem(T Data)
        {
            if (Data == null)
            {
                throw new ArgumentNullException(nameof(Data));
            }
            _workItems.Enqueue(Data);
            _signal.Release();
        }

        protected virtual void ExeDequeue(T data)
        {
            // TODO
        }
    }
}
