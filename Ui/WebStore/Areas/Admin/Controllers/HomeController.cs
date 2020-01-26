using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebStore.DomainNew.Filters;
using WebStore.DomainNew.ViewModels;
using WebStore.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            var products = _productService.GetProducts(new ProductFilter());
            return View(products);
        }
        public IActionResult Edit(int? id)
        {
            var notParentSections = _productService
                .GetSections()
                .Where(s => s.ParentId != null);
            var brands = _productService.GetBrands();
            //проверка
            if (id is null)
                return View(new ProductViewModel
                {
                    Sections = new SelectList(notParentSections, "Id", "Name"),
                    Brands = new SelectList(brands, "Id", "Name")

                });
            var product = _productService.GetProductById(id.Value);
            if (product is null)
                return NotFound();

            return View(product.ToViewMadel(notParentSections, brands));
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel model)
        {
            var notParentSections = _productService
               .GetSections()
               .Where(s => s.ParentId != null);
            var brands = _productService.GetBrands();
        }

        public IActionResult Delete(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null)
            
                return NotFound();
                return View(product.ToViewModel(new List<Section>(), new List<Brand>()));
            }
        
                 [HttpPost]
                  public IActionResult Delete(ProductViewModel model)
                   {
            _productService.DeleteProduct(model.Id);
            return RedirectToAction(nameof(ProductList));

        
                   
}

    
}}