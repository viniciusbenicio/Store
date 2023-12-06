using Store.Domain.Entites;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeOrderRepository : IOrderRepository
    {
        public void Save(Order order) { }
    }
}
