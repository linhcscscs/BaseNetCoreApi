﻿using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Infrastructure.AttributeCollection;
using System.ComponentModel;

namespace BaseNetCoreApi.Values
{
    public class ReturnCode
    {
        private EReturnCode? _eReturnCode;
        private string? _errorCode = null;
        private string? _errorMsg = null;
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
                return _errorCode ?? _eReturnCode?.GetMa() ??  "";
            }
            set
            {
                _errorCode = value;
            }
        }
        public string ErrorMsg
        {
            get
            {
                return _errorMsg ?? _eReturnCode?.GetDescription() ??  "";
            }
            set
            {
                _errorMsg = value;
            }
        }
        public object Object { get; set; }
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

        #region Common
        [Description("Không tìm thấy tài nguyên"), StatusCode(404)]
        NotFound,
        #endregion
    }
}
