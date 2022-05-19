// See https://aka.ms/new-console-template for more information

namespace IOC_Container.Types
{
    public class RandomGuiGenerator
    {
        public Guid RandomGuid { get; set; } = Guid.NewGuid();
    }
}