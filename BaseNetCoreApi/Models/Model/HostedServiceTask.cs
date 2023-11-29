namespace BaseNetCoreApi.Models.Model
{
    public enum EHostedServiceTask
    {
        ClearExpRefreshToken,
        ClearTempFile
    }
    public class HostedServiceTask
    {
        public virtual EHostedServiceTask EHostedServiceTask { get; }
    }

    public class ClearExpRfTokenTask : HostedServiceTask
    {
        public override EHostedServiceTask EHostedServiceTask
        {
            get
            {
                return EHostedServiceTask.ClearExpRefreshToken;
            }
        }
    }

    public class ClearTempFileTask : HostedServiceTask
    {
        public override EHostedServiceTask EHostedServiceTask
        {
            get
            {
                return EHostedServiceTask.ClearTempFile;
            }
        }
    }

}
