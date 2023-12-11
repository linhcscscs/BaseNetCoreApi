namespace BaseNetCoreApi.Infrastructure.AttributeCollection
{
    public interface ICustomAttribute<T>
    {
        public T GetValue();
    }
}
