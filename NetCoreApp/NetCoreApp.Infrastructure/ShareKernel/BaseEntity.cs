namespace NetCoreApp.Infrastructure.ShareKernel
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }

        /// <summary>
        /// True if base entity is default
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
