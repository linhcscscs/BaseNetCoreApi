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
    public class HasPermissionAttribute : Attribute, IAuthorizationFilter
    {
        private SysTypeAccess _sysTypeAccess;
        public HasPermissionAttribute(SysTypeAccess sysTypeAccess)
        {
            _sysTypeAccess = sysTypeAccess;
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
            var permissons = workcontext.Permissons;

            var isRoot = workcontext.IsRoot || workcontext.IsRootSys;

            var hasPermission = false;
            switch (_sysTypeAccess)
            {
                case SysTypeAccess.View:
                    hasPermission = permissons.Any(q => q.IsView == 1) || isRoot;
                    break;
                case SysTypeAccess.Add:
                    hasPermission = permissons.Any(q => q.IsAdd == 1) || isRoot;
                    break;
                case SysTypeAccess.Edit:
                    hasPermission = permissons.Any(q => q.IsEdit == 1) || isRoot;
                    break;
                case SysTypeAccess.Delete:
                    hasPermission = permissons.Any(q => q.IsDelete == 1) || isRoot;
                    break;
                case SysTypeAccess.Upload:
                    hasPermission = permissons.Any(q => q.IsUpload == 1) || isRoot;
                    break;
                case SysTypeAccess.Auth:
                    hasPermission = permissons.Any(q => q.IsAuth == 1)|| isRoot;
                    break;
                case SysTypeAccess.IsRoot:
                    hasPermission = isRoot;
                    break;
                case SysTypeAccess.IsMasterRoot:
                    hasPermission = workcontext.IsRootSys;
                    break;
                default:
                    break;
            }
            if (!hasPermission)
            {
                context.Result = ReturnHelper.ReturnErrorStatusCode(new ReturnCode(EReturnCode.Forbidden));
            }
        }
    }
}
