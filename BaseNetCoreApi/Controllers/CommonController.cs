using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Models.ViewModel;
using BaseNetCoreApi.Services;
using BaseNetCoreApi.Services.Interface;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Swashbuckle.AspNetCore.Swagger;
using System.Diagnostics;
using System.Reflection;

namespace BaseNetCoreApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CommonController : ControllerBase
    {
        #region Contructor
        private ILogger<CommonController> _logger;
        private readonly IActionDescriptorCollectionProvider _actionDescriptorCollectionProvider;
        private IAuthenticateService _authenticateService;
        public CommonController(ILogger<CommonController> logger, IAuthenticateService authenticateService, IActionDescriptorCollectionProvider actionDescriptorCollectionProvider)
        {
            _logger = logger;
            _authenticateService = authenticateService;
            _actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
        }
        #endregion

        #region API
        [AllowAnonymous]
        [HttpGet]
        [HttpGet("endpoints")]
        public IActionResult GetEndpoints()
        {
            var endpointUrls = GetEndpointUrls();
            return Ok(endpointUrls);
        }

        private List<string> GetEndpointUrls()
        {
            var endpointUrls = new List<string>();

            var actionDescriptors = _actionDescriptorCollectionProvider.ActionDescriptors.Items;

            foreach (var actionDescriptor in actionDescriptors)
            {
                if (actionDescriptor is ControllerActionDescriptor controllerActionDescriptor)
                {
                    var endpointUrl = GetEndpointUrl(controllerActionDescriptor);
                    endpointUrls.Add(endpointUrl);
                }
            }

            return endpointUrls;
        }

        private string GetEndpointUrl(ControllerActionDescriptor controllerActionDescriptor)
        {
            var endpointUrl = $"{controllerActionDescriptor.DisplayName}: {controllerActionDescriptor.AttributeRouteInfo?.Template}";
            return endpointUrl;
        }
        #endregion
    }
}
