using BaseNetCoreApi.Helper;
using BaseNetCoreApi.Service;
using BaseNetCoreApi.Values;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace BaseNetCoreApi.Middleware
{
    public class WorkContextMiddleware
    {
        private readonly RequestDelegate _next;
        public WorkContextMiddleware(RequestDelegate next) => _next = next;
        public async Task Invoke(HttpContext httpContext, IWorkContextService workContext)
        {
            var isAuthen = httpContext.User?.Identity?.IsAuthenticated ?? false;
            if (!isAuthen)
            {
                goto nextSection;
            }
            var user = httpContext.User!;
            var snguoiDingId = AuthHelper.GetByClaim(user, UserClaimKey.NguoiDungId);
            var sSessionId = AuthHelper.GetByClaim(user, UserClaimKey.SessionId);
            if (int.TryParse(snguoiDingId, out var NguoiDungId))
            {
                workContext.NguoiDungId = NguoiDungId;
            };
            if (Guid.TryParse(sSessionId, out var SessionId))
            {
                workContext.SessionId = SessionId;
            }
        nextSection:
            await _next(httpContext);
        }
    }
}
