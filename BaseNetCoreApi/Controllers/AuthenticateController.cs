using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticateController : ControllerBase
    {
        #region Contructor
        private INguoiDungService _nguoiDungService;
        private ILogger<AuthenticateController> _logger;
        private IAuthenticateService _authenticateService;
        public AuthenticateController(INguoiDungService nguoiDungService, ILogger<AuthenticateController> logger, IAuthenticateService authenticateService)
        {
            _nguoiDungService = nguoiDungService;
            _logger = logger;
            _authenticateService = authenticateService;
        }
        #endregion

        #region API
        [Route("/login")]
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody] LoginRequest model)
        {
            try
            {
                var ret = _authenticateService.Login(model, out var authResponse);
                if (ret.Success)
                {
                    return UltilHelper.ReturnSuccess(authResponse);
                }
                else
                {
                    return UltilHelper.ReturnErrorStatusCode(ret);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("AuthenticateController.Login", ex);
                return UltilHelper.ExceptionErrorStatus500;
            }
        }

        [Route("/refreshtoken")]
        [AllowAnonymous]
        [HttpPost]
        public IActionResult RefreshToken([FromBody] RefreshAccessTokenRequest model)
        {
            try
            {
                var ret = _authenticateService.RefreshAccessToken(model, out var authResponse);
                if (ret.Success)
                {
                    return UltilHelper.ReturnSuccess(authResponse);
                }
                else
                {
                    return UltilHelper.ReturnErrorStatusCode(ret);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("AuthenticateController.RefreshToken", ex);
                return UltilHelper.ExceptionErrorStatus500;
            }
        }

        [Route("/logout")]
        [HttpPost]
        public IActionResult Logout([FromBody] LogoutRequest model)
        {
            try
            {
                _authenticateService.Logout(model);
                return UltilHelper.ReturnSuccess();
            }
            catch (Exception ex)
            {
                _logger.LogError("AuthenticateController.Logout", ex);
                return UltilHelper.ExceptionErrorStatus500;
            }
        }


        #endregion
    }
}
