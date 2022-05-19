// See https://aka.ms/new-console-template for more information

namespace IOC_Container.Container
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; set; }

        public object Implementation { get; internal set; }

        public ServiceLifetime Lifetime { get; }

        public ServiceDescriptor(object implementation, ServiceLifetime lifetime)
        {
            ServiceType = implementation.GetType();
            Implementation = implementation;
            Lifetime = lifetime;
        }

        public ServiceDescriptor(Type serviceType, ServiceLifetime lifetime)
        {
            ServiceType = serviceType;
            Lifetime = lifetime;
        }
    }
}