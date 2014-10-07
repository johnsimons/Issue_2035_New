using NServiceBus;

namespace Messages.Commands
{
    public class RequestDataMessage: ICommand
    {
        public int Id { get; set; }
    }
}
