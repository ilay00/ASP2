using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebStore.DomainNew.Dto;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Filters;
using WebStore.Interfaces;
using WebStore.Interfaces.Services;
namespace WebStore.ServicesHosting.Controllers
{
    [Produces("application/json")]
    [Route("api/products")]
    public class ProductsApiController : ControllerBase, IProductService
    {
        private readonly IProductService _productData;
        public ProductsApiController(IProductService productData)
        {
            _productData = productData ?? throw new ArgumentException(nameof(productData));
        }
        [HttpGet("sections")]
        public IEnumerable<Section> GetSections()
        {
            return _productData.GetSections();
        }
        [HttpGet("brands")]
        public IEnumerable<Brand> GetBrands()
        {
            return  _productData.GetBrands();
        }
        /*[HttpPost()]
        [ActionName("Post")]*/
        public IEnumerable<ProductDto> GetProducts([FromBody]ProductFilter filter)
        {
            return _productData.GetProducts(filter);

        }
        public ProductDto GetProductById(int id)
        {
            return _productData.GetProductById(id);
        }


        /*

          [HttpGet("{id}"), ActionName("Get")]

          {
              var product = _productData.GetProductById(id);
              return product;
          }*/
    }

    }
}