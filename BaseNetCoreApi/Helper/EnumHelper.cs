using BaseNetCoreApi.Infrastructure.AttributeCollection;
using System.ComponentModel;
using System.Reflection;
using static BaseNetCoreApi.Values.ScopePermission;

namespace BaseNetCoreApi.Helper
{
    public static class EnumHelper
    {
        #region Attribute Extension
        public static string GetDescription(this Enum GenericEnum)
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return ((DescriptionAttribute)_Attribs.ElementAt(0)).Description;
                }
            }
            return GenericEnum.ToString();
        }
        public static string GetName(this Enum GenericEnum) => GetAttribute<NameAttribute, string>(GenericEnum) ?? "";
        public static string GetMa(this Enum GenericEnum)
        {
            // GetAttribute<MaAttribute, string>(GenericEnum) ?? "";
            return GenericEnum.ToString();
        }
        public static int GetStatusCode(this Enum GenericEnum)
        {
            var ret = GetAttribute<StatusCodeAttribute, int>(GenericEnum);
            if (ret == 0) ret = 500;
            return ret;
        }
        public static EScopePermission GetParentScopePermission(this Enum GenericEnum) => GetAttribute<ParentScopeAttribute, EScopePermission>(GenericEnum);
        public static valueType? GetAttribute<Atribute, valueType>(this Enum GenericEnum)
            where Atribute : Attribute, ICustomeAttribute<valueType>
        {
            Type genericEnumType = GenericEnum.GetType();
            MemberInfo[] memberInfo = genericEnumType.GetMember(GenericEnum.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var _Attribs = memberInfo[0].GetCustomAttributes(typeof(Atribute), false);
                if ((_Attribs != null && _Attribs.Count() > 0))
                {
                    return (valueType)((Atribute)_Attribs.ElementAt(0)).GetValue();
                }
            }
            return default;
        }
        #endregion

        #region Common
        public static T GetEnumByName<T>(string name) where T : Enum
        {
            return (T)Enum.Parse(typeof(T), name);
        }
        #endregion
    }
}
