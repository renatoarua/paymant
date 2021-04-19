using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    public interface IStudenRepository
    {
        bool DocumentExists(string document);
        bool EmailExists(string document);
        void CreateSubscription(Student student);
    }
}