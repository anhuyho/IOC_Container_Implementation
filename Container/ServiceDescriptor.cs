// See https://aka.ms/new-console-template for more information

namespace IOC_Container.Container
{
    public class ServiceDescriptor
    {
        public Type ServiceType { get; set; }

        public Type ImplementationType { get; set; }

        public object Implementation { get; internal set; }

        public ServiceLifetime Lifetime { get; }

        public ServiceDescriptor(object implementation, ServiceLifetime lifetime)
        {
            ServiceType = implementation.GetType();
            if (lifetime == ServiceLifetime.Singleton)
            {
                Implementation = implementation;
            }
            
            Lifetime = lifetime;
        }

        public ServiceDescriptor(Type serviceType, ServiceLifetime lifetime)
        {
            ServiceType = serviceType;
            Lifetime = lifetime;
        }

        public ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifetime lifetime)
        {
            ServiceType = serviceType;
            Lifetime =  lifetime;
            ImplementationType = implementationType;
        }
    }
}