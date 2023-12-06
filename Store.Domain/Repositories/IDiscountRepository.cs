using Store.Domain.Entites;

namespace Store.Domain.Repositories
{
    public interface IDiscountRepository
    {
        Discount Get(string code);
    }
}
