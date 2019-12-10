using System.Collections.Generic;
using WebAppSATES.Domain.Entities;

namespace WebAppSATES.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter Filter = null);
        Product GetProductById(int id);
    }
}
