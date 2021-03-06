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

        public void RegisterSingleton<T>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(T), ServiceLifetime.Singleton));
        }

        internal void RegisterSingleton<TService, TImplementaion>() where TImplementaion : TService
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementaion), ServiceLifetime.Singleton));
        }

        internal void RegisterTransient<TService, TImplementaion>() where TImplementaion : TService
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementaion), ServiceLifetime.Transient));
        }

        public void RegisterTransient<T>()
        {
            _serviceDescriptors.Add(new ServiceDescriptor(typeof(T), ServiceLifetime.Transient));
        }
        public void RegisterTransient<T>(T implementation)
        {
            _serviceDescriptors.Add(new ServiceDescriptor(implementation, ServiceLifetime.Transient));
        }
        internal DiContainer GenerateContainer()
        {
            return new DiContainer(_serviceDescriptors);
        }
    }
}