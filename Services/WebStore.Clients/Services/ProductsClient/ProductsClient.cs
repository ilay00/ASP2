using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

using WebStore.DomainNew.Dto;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Filters;
using WebStore.Interfaces;
using WebStore.Interfaces.Services;
namespace WebStore.Clients.Services.Products
{
    public class ProductsClient : BaseClient, IProductService
    {
        protected sealed override string ServiceAddress { get; } = "api/products";
        public ProductsClient(IConfiguration configuration) :
        base(configuration)
        {
            ServiceAddress = "api/products";
        }
       
        public IEnumerable<Section> GetSections()
        {
            var url = $" {ServiceAddress} /sections";
            var result = Get<List<Section>>(url);
            return result;
        }
        public IEnumerable<Brand> GetBrands()
        {
            var url = $" {ServiceAddress} /brands";
            var result = Get<List<Brand>>(url);
            return result;
        }
        public IEnumerable<ProductDto> GetProducts(ProductFilter filter)
        {
            var url = $" {ServiceAddress} ";
            var response = Post(url, filter);
            var result =
            response.Content.ReadAsAsync<IEnumerable<ProductDto>>().Result;
            return result;
        }
        public ProductDto GetProductById(int id)
        {
            var url = $" {ServiceAddress} / {id} ";
            var result = Get<ProductDto>(url);
            return result;
        }

      
    }

   
}