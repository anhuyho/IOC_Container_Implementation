using IOC_Container.Types.Interfaces;

namespace IOC_Container.Types.Implementations
{
    public class MyService: IMyService
    {
        private readonly IRandomGuidProvider _randomGuidProvider;

        public MyService(IRandomGuidProvider randomGuidProvider)
        {
            _randomGuidProvider = randomGuidProvider;
        }


        public void DoSomeThing() {
            Console.WriteLine(_randomGuidProvider.RandomGuid);
        }
    }
}
