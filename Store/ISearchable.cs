

namespace Lab5
{
    internal interface ISearchable
    {
        List<Product> SearchByCriteria(string category, decimal minPrice, decimal maxPrice);
    }
}
