using System;
using System.Collections.Generic;
using System.Text;
using WebStore.DomainNew.Dto;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Filters;

namespace WebStore.Interfaces.Services
{
    public interface IProductData
    {
        IEnumerable<Brand> GetBrands();
        IEnumerable<Section> GetSections();
        object GetProductById(int id);
        IEnumerable<ProductDto> GetProducts(ProductFilter filter);
    }
}
