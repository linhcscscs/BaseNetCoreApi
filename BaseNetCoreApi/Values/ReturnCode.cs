using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.AttributeCollection;
using System.ComponentModel;

namespace BaseNetCoreApi.Values
{
    public class ReturnCode
    {
        private EReturnCode? _eReturnCode;
        private string _errorCode;
        private string _errorMsg;
        public ReturnCode(EReturnCode returnCode)
        {
            _eReturnCode = returnCode;
        }
        public ReturnCode() { }
        public EReturnCode? EReturnCode
        {
            set
            {
                _eReturnCode = value;
            }
        }

        public bool Success
        {
            get
            {
                return _eReturnCode == null && string.IsNullOrEmpty(ErrorCode) && string.IsNullOrEmpty(ErrorMsg);
            }
        }
        public string ErrorCode
        {
            get
            {
                return _eReturnCode?.GetMa() ?? _errorCode ?? "";
            }
            set
            {
                _errorCode ??= value;
            }
        }
        public string ErrorMsg
        {
            get
            {
                return _eReturnCode?.GetDescription() ?? _errorMsg ?? "";
            }
            set
            {
                _errorMsg ??= value;
            }
        }
        public int StatusCode() => _eReturnCode?.GetStatusCode() ?? 500;
    }
    public enum EReturnCode
    {
        #region System
        [Description("Lỗi không xác định"), StatusCode(500)]
        InternalErrorException,
        #endregion

        #region Auth
        [Description("Tài khoản hoặc mật khẩu không đúng"), StatusCode(403)]
        WrongUsernameOrPassword,
        [Description("Phiên đăng nhập đã kết thúc, vui lòng đăng nhập lại"), StatusCode(401)]
        TokenInvalid,
        [Description("AccessToken hết hạn"), StatusCode(401)]
        TokenExpired,
        [Description("Chưa đăng nhập"), StatusCode(401)]
        Unauthorized,
        [Description("Bạn không được phép truy cập tài nguyên này"), StatusCode(403)]
        Forbidden,
        #endregion

        #region Internal

        #region File
        [Description("Hãy chọn file tải lên"), StatusCode(422)]
        NoFileUploaded,
        [Description("File tải lên không đúng định dạng"), StatusCode(422)]
        FileExtensionInvalid,
        #endregion

        #endregion
    }
}
