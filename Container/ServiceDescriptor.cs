// See https://aka.ms/new-console-template for more information

namespace IOC_Container.Container
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; set; }

        public object Implementation { get; }

        public ServiceLifetime Lifetime { get; internal set; }

        public ServiceDescriptor(object implementation, ServiceLifetime lifetime)
        {
            ServiceType = implementation.GetType();
            Implementation = implementation;
            Lifetime = lifetime;
        }
    }
}