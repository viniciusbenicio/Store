using Store.Domain.Entites;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeDeliveryFeeRepository : IDeliveryFeeRepository
    {
        decimal IDeliveryFeeRepository.Get(string zipCode)
        {
            return 10;
        }
    }
}
