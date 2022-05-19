// See https://aka.ms/new-console-template for more information

namespace IOC_Container.Container
{
    public class DiServiceCollecion
    {
        private List<ServiceDescriptor> _serviceDescriptors = new List<ServiceDescriptor>();

        public void RegisterSingleton<T>(T implementation)
        {
            _serviceDescriptors.Add(new ServiceDescriptor(implementation, ServiceLifetime.Singleton));
        }
        internal DiContainer GenerateContainer()
        {
            return new DiContainer(_serviceDescriptors);
        }
    }
}