using Store.Domain.Entites;

namespace Store.Domain.Repositories
{
    public interface IOrderRepository
    {
        Order Save(Order order);
    }
}
