using System.Collections.Generic;
using WebStore.DomainNew.Dto;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Filters;

namespace WebStore.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Section> GetSections();
        IEnumerable<Brand> GetBrands();
        PagedProductDto GetProducts(ProductFilter filter);

        /// <summary>
        /// Получить товар по Id
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Сущность Product, если нашел, иначе null</returns>
        ProductDto GetProductById(int id);

        /// <summary>Секция по Id</summary>
        /// <param name="id">Id</param>
        Section GetSectionById(int id);

        /// <summary>Бренд по Id</summary>
        /// <param name="id">Id</param>
        Brand GetBrandById(int id);
        /// <summary>
        /// создать
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        SaveRersultDto CreateProduct(ProductDto product);
        /// <summary>
        /// обновить
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        SaveRersultDto UpdateProduct(ProductDto product);
        /// <summary>
        /// удолить
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        SaveRersultDto DeleteProduct(int productId);

    }
}