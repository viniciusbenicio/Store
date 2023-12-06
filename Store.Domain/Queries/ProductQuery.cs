using Store.Domain.Entites;
using System.Linq.Expressions;

namespace Store.Domain.Queries
{
    public static class ProductQuery
    {
        public static Expression<Func<Product, bool>> GetActiveProducts()
        {
            return x => x.Active;
        }

        public static Expression<Func<Product, bool>> GetInactiveProducts()
        {
            return x => x.Active == false;
        }

    }
}
