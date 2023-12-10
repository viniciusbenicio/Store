using Store.Domain.Commands;

namespace Store.Domain.Utils
{
    public static class ExtractGuids
    {
        public static IEnumerable<Guid> Extract(IList<CreateOrderItemCommand> Items)
        {
            var guids = new List<Guid>();

            foreach (var item in Items)
                guids.Add(item.Product);

            return guids;

        }
    }
}
