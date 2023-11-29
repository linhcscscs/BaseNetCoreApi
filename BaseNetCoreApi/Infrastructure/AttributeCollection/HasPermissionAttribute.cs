using BaseNetCoreApi.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;
using static BaseNetCoreApi.Values.ScopePermission;
using Microsoft.Extensions.Caching.Memory;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Values;

namespace BaseNetCoreApi.Infrastructure.AttributeCollection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class HasPermissionAttribute : Attribute, IAuthorizationFilter
    {
        private EScopePermission _scopePermission;
        public HasPermissionAttribute(EScopePermission scopePermission)
        {
            _scopePermission = scopePermission;
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
                context.Result = UltilHelper.ReturnErrorStatusCode(new ReturnCode(EReturnCode.Unauthorized));
                return;
            }
            var permissons = workcontext.Permissons;
            if (!permissons.Any(x => x.ScopePermission == _scopePermission))
            {
                context.Result = UltilHelper.ReturnErrorStatusCode(new ReturnCode(EReturnCode.Forbidden));
            }
        }
    }
}
