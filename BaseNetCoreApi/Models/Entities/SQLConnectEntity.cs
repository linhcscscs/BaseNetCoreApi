using BaseNetCoreApi.Helper;

namespace BaseNetCoreApi.Models.Entities
{
    public class SQLConnectEntity
    {
        #region Properties
        private int _ma_nam_hoc;
        private string _ConnectionStringReadStr01;
        private string _ConnectionStringReadStr02;
        private string _ConnectionStringWriteStr;
        #endregion
        #region Contructor
        public SQLConnectEntity(int ma_nam_hoc,
            string ConnectionStringReadStr01,
            string ConnectionStringReadStr02,
            string ConnectionStringWriteStr)
        {
            _ma_nam_hoc = ma_nam_hoc;
            _ConnectionStringReadStr01 = ConnectionStringReadStr01;
            _ConnectionStringReadStr02 = ConnectionStringReadStr02;
            _ConnectionStringWriteStr = ConnectionStringWriteStr;
        }
        #endregion
        #region GET SET
        public int MA_NAM_HOC
        {
            get
            {
                return _ma_nam_hoc;
            }
        }
        public string SQL_CONNECTION_STRING_READ_01
        {
            get
            {
                try
                {
                    return ConfigurationHelper.GetConnectionStringByName(_ConnectionStringReadStr01);
                }
                catch
                {
                    return ConfigurationHelper.GetConnectionStringByName(_ConnectionStringWriteStr);
                }
            }
        }
        public string SQL_CONNECTION_STRING_READ_02
        {
            get
            {
                try
                {
                    return ConfigurationHelper.GetConnectionStringByName(_ConnectionStringReadStr02);
                }
                catch
                {
                    return ConfigurationHelper.GetConnectionStringByName(_ConnectionStringWriteStr);
                }
            }
        }
        public string SQL_CONNECTION_STRING_WRITE
        {
            get
            {
                return ConfigurationHelper.GetConnectionStringByName(_ConnectionStringWriteStr);
            }
        }
        #endregion
    }
}
