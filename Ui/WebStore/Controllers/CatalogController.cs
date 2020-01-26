﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebStore.DomainNew.Filters;
using WebStore.DomainNew.ViewModels;
using WebStore.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;
        private readonly IConfiguration _configuration;

        public CatalogController(IProductService productService, IConfiguration configuration)
        {
            _productService = productService;
            _configuration = configuration;
        }

        public IActionResult Shop(int? sectionId, int? brandId, int page = 1)
        {
            var pageSize = int.Parse(_configuration["PageSize"]);
            var products = GetProducts( sectionId,  brandId,  page, out var totalCount);

           

            // сконвертируем в CatalogViewModel
            var model = new CatalogViewModel()
            {
                BrandId = brandId,
                SectionId = sectionId,
                Products = products,
                PageViewModel =new PageViewModel
                {
                    PageSize=pageSize,
                    PageNumber=page,
                    TotalItems=totalCount
                }
             };

            return View(model);
        }
        public IActionResult GetFilteredItems(int? sectionId, int? brandId, int page = 1)
        {
            var productsModel = GetProducts(sectionId, brandId, page, out var totalCount);
            return PartialView("Partial/FeaturedItems", productsModel);
        }

        private IEnumerable<PageViewModel> GetProducts(int? sectionId, int? brandId, int page, out object totalCount)
        {
            var products = _productService.GetProducts(
              new ProductFilter
              {
                  SectionId = sectionId,
                  BrandId = brandId,
                  Page = page,
                  PageSize = int.Parse(_configuration["PageSize"])
              });
            totalCount = products.TotalCount;
            return products.Products.Select(p => new ProductViewModel()
            {
                Id = p.Id,
                ImageUrl = p.ImageUrl,
                Name = p.Name,
                Order = p.Order,
                Price = p.Price,
                BrandName = p.Brand?.Name ?? String.Empty
            }).OrderBy(p => p.Order)
           .ToList();
    }

        public IActionResult ProductDetails(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(new ProductViewModel
            {
                Id = product.Id,
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Order = product.Order,
                Price = product.Price,
                BrandName = product.Brand?.Name ?? string.Empty
            });
        }
    }
}
