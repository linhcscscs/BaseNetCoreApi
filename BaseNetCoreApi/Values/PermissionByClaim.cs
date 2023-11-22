using System.ComponentModel;
using BaseNetCoreApi.Infrastructure.AttributeCollection;

namespace BaseNetCoreApi.Values
{
    public class PermissionByClaim
    {
        public enum EScopePermission
        {
            [Description("testScope"), Name("testScope")]
            testScope = 1,
        }
        public enum EPermissionByClaim
        {
            [Description("Đọc"), Name("Quyền đọc")]
            Read,
            [Description("Đọc của người khác"), Name("Quyền đọc của người khác")]
            ReadOther,
            [Description("Chỉnh sửa"), Name("Quyền chỉnh sửa")]
            Modify,
            [Description("Chỉnh sửa của người khác"), Name("Quyền chỉnh sửa người khác")]
            ModifyOther,
        }
    }
}
