using static BaseNetCoreApi.Values.PermissionByClaim;

namespace BaseNetCoreApi.Infrastructure.AttributeCollection
{
    public interface ICustomeAttribute<T>
    {
        public T GetValue();
    }
    public class PermissionScopeAttribute : Attribute , ICustomeAttribute<EScopePermission>
    {
        private EScopePermission _value;
        public PermissionScopeAttribute(EScopePermission value) { _value = value; }

        public EScopePermission GetValue()
        {
            return _value;
        }
    }
}