using static BaseNetCoreApi.Values.PermissionByClaim;

namespace BaseNetCoreApi.Infrastructure.AttributeCollection
{
    class ParentScopeAttribute : Attribute, ICustomeAttribute<EScopePermission>
    {
        private EScopePermission _value;
        public ParentScopeAttribute(EScopePermission value) { _value = value; }

        public EScopePermission GetValue()
        {
            return _value;
        }
    }
}
