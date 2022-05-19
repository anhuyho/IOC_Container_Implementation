// See https://aka.ms/new-console-template for more information

namespace IOC_Container.Container
{
    public class DiContainer
    {
        private List<ServiceDescriptor> _serviceDescriptors;

        public DiContainer(List<ServiceDescriptor> serviceDescriptors)
        {
            _serviceDescriptors = serviceDescriptors;
        }

        public T GetService<T>()
        {
            var descriptor = _serviceDescriptors.SingleOrDefault(x => x.ServiceType == typeof(T));


            if (descriptor == null)
            {
                throw new Exception($"Service of type {typeof(T).Name} is not registered");
            }
            if (descriptor.Implementation is not null)
            {
                return (T)descriptor.Implementation;
            }

            if (descriptor.ImplementationType is not null)
            {

            }

            var implementation = (T)Activator.
                CreateInstance(descriptor.ImplementationType ?? descriptor.ServiceType);

            if (descriptor.Lifetime == ServiceLifetime.Singleton)
            {
                descriptor.Implementation = implementation;
            }
            return implementation;

            return default;
        }
    }
}