using BaseNetCoreApi.Helper;
using static BaseNetCoreApi.Values.ScopePermission;

namespace BaseNetCoreApi.Models.Entities
{
    public class PermissonEntity
    {
        private EScopePermission _scopePermission;
        public PermissonEntity(EScopePermission value)
        {
            _scopePermission = value;
        }

        public PermissonEntity(string EScopePermissionName)
        {
            try
            {
                _scopePermission = EnumHelper.GetEnumByName<EScopePermission>(EScopePermissionName);
            }
            catch { }
        }

        public int Id
        {
            get
            {
                return (int)_scopePermission;
            }
        }
        public EScopePermission ScopePermission
        {
            get
            {
                return _scopePermission;
            }
        }
        public string Code
        {
            get
            {
                return ScopePermission.GetMa();
            }
        }
        public string Name
        {
            get
            {
                return ScopePermission.GetName();
            }
        }
        public string Description
        {
            get
            {
                return ScopePermission.GetDescription();
            }
        }
        public EScopePermission ParentScopePermission
        {
            get
            {
                return _scopePermission.GetParentScopePermission();
            }
        }
        public int ParentId
        {
            get
            {
                return (int)ParentScopePermission;
            }
        }
    }
}
