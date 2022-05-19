using IOC_Container.Types.Interfaces;

namespace IOC_Container.Types.Implementations
{
    public class MyService: IMyService
    {
        private readonly Guid RandomGuid = Guid.NewGuid();

        public void DoSomeThing() {
            Console.WriteLine(RandomGuid);
        }
    }
}
