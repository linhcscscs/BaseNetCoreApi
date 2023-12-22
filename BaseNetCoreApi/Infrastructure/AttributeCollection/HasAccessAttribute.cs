using BaseNetCoreApi.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using Microsoft.Extensions.Caching.Memory;
using BaseNetCoreApi.Values;
using BaseNetCoreApi.DomainService;
using BaseNetCoreApi.DomainService.Interface;

namespace BaseNetCoreApi.Infrastructure.AttributeCollection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class HasAccessAttribute : Attribute, IAuthorizationFilter
    {
        private string _route;
        public HasAccessAttribute(string route)
        {
            _route = route;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // skip authorization if action is decorated with [AllowAnonymous] attribute
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;

            // authorization
            var workcontext = context.HttpContext.RequestServices.GetService<IWorkContextService>();
            if (!workcontext.IsAuthenticated)
            {
                context.Result = ReturnHelper.ReturnErrorStatusCode(new ReturnCode(EReturnCode.Unauthorized));
                return;
            }
            if (workcontext.IsRoot)
            {
                return;
            }
            var permissons = workcontext.Permissons;
            String originalPath = new Uri(workcontext.FullRequestURL).OriginalString;
            String parentDirectory = originalPath.Substring(0, originalPath.LastIndexOf("/"));
            var hasPermission = false;

            if (!hasPermission)
            {
                context.Result = ReturnHelper.ReturnErrorStatusCode(new ReturnCode(EReturnCode.Forbidden));
            }
        }
    }
}
