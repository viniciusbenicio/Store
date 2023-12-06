using Store.Domain.Entites;

namespace Store.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(string document);
    }
}
