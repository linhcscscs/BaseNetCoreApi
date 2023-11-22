using BaseNetCoreApi.Infrastructure.AttributeCollection;
using System.ComponentModel;
using System.Reflection;

namespace BaseNetCoreApi.Helper
{
    public static class EnumHelper
    {
        #region Common Extension
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
    }
}
