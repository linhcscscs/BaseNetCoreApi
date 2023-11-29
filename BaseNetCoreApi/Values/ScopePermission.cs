using System.ComponentModel;
using System.Security.Permissions;
using BaseNetCoreApi.Infrastructure.AttributeCollection;

namespace BaseNetCoreApi.Values
{
    public class ScopePermission
    {
        public enum EScopePermission
        {
            [Description("Admin"), Name("testScope")]
            IsAdmin = 1,

            [Description("Quyền truy cập TestAPI"), Name("testScope")]
            TestAPI = 10,

            [Description("Quyền Đọc cập TestAPI"), Name("R_TestAPI"), ParentScope(EScopePermission.TestAPI)]
            TestAPI_R = 1000,

            [Description("Quyền Ghi TestAPI"), Name("W_TestAPI"), ParentScope(EScopePermission.TestAPI)]
            TestAPI_W,
        }
    }
}
