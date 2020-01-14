﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Interfaces;

namespace WebStore.ServicesHosting.Controllers
{
    public class SitemapController:Controller
    {
        private readonly IProductService  _productService;
        public SitemapController(IProductService productService)
        {
            _productService - productService;
        }

        public IActionResult Index()
        {
            var nodes = new List<SitemapNode>
            {
                new SitemapNode(Url.Action("Index","Home")),
                new SitemapNode(Url.Action("Shop","Catalog")),
                new SitemapNode(Url.Action("BlogSingle","Home")),
                new SitemapNode(Url.Action("Blog","Home")),
                new SitemapNode(Url.Action("ContactUs","Home"))
                
            };

            var sections = _productService.GetSections();
            foreach (var section in sections)
            {
                if (section.ParentId.HasValue)
                    nodes.Add(new SitemapNode(Url.Action(
                        "Shop",
                        "Catalog",
                        new { sectionId = section.Id })));
            }

            // список всех брендов
            var brands = _productService.GetBrands();
            foreach (var brand in brands)
            {
                nodes.Add(new SitemapNode(Url.Action(
                    "Shop",
                    "Catalog",
                    new { brandId = brand.Id })));
            }

            // список всех страниц товаров
            var products = _productService.GetProducts(new ProductFilter());
            foreach (var productDto in products)
            {
                nodes.Add(new SitemapNode(Url.Action(
                    "ProductDetails",
                    "Catalog",
                    new { id = productDto.Id })));
            }
            return new SitemapProvider()
                .CreateSitemap(new SitemapModel(nodes));

        }
    }
}
