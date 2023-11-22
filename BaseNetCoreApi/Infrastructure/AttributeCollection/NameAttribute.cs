namespace BaseNetCoreApi.Infrastructure.AttributeCollection
{
    class NameAttribute : Attribute, ICustomeAttribute<string>
    {
        private string _value;
        public NameAttribute(string value) { _value = value; }

        public string GetValue()
        {
            return _value;
        }
    }
}
