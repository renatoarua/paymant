using PaymentContext.Shared.Commands;

namespace PaymentContext.Shared.Handlers
{
    public interface IHandler<t> where t : ICommand
    {
        ICommandResult Handle(t command);
    }
}