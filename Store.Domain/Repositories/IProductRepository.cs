using Store.Domain.Entites;

namespace Store.Domain.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get(IEnumerable<Guid> ids);
    }
}
