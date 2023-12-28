using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthenticateController : ControllerBase
    {
        #region Contructor
        private ILogger<AuthenticateController> _logger;
        private IAuthenticateService _authenticateService;
        public AuthenticateController(ILogger<AuthenticateController> logger, IAuthenticateService authenticateService)
        {
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
                    return ReturnHelper.ReturnSuccess(authResponse);
                }
                else
                {
                    return ReturnHelper.ReturnErrorStatusCode(ret);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"Login", [model]);
                return ReturnHelper.ExceptionErrorStatus500;
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
                    return ReturnHelper.ReturnSuccess(authResponse);
                }
                else
                {
                    return ReturnHelper.ReturnErrorStatusCode(ret);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "RefreshToken", [model]);
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }

        [Route("/logout")]
        [HttpPost]
        public IActionResult Logout([FromBody] LogoutRequest model)
        {
            try
            {
                _authenticateService.Logout(model);
                return ReturnHelper.ReturnSuccess();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex ,"Logout",[model]);
                return ReturnHelper.ExceptionErrorStatus500;
            }
        }
        #endregion
    }
}
