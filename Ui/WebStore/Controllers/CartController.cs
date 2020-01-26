﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.DomainNew.Dto.Order;
using WebStore.DomainNew.ViewModels;
using WebStore.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IOrdersService _ordersService;

        public CartController(ICartService cartService, IOrdersService ordersService)
        {
            _cartService = cartService;
            _ordersService = ordersService;
        }

        public IActionResult Details()
        {
            var model = new OrderDetailsViewModel()
            {
                CartViewModel = _cartService.TransformCart(),
                OrderViewModel = new OrderViewModel()
            };

            return View(model);
        }

        public IActionResult DecrementFromCart(int id)
        {
            _cartService.DecrementFromCart(id);
            return Json(new
            {
                id,
                message = "Количество товара уменьшено на 1"
            });
        }

        public IActionResult RemoveFromCart(int id)
        {
            _cartService.RemoveFromCart(id);
            return Json(new { id, message = "Товар удален из корзины" });
        }

        public IActionResult RemoveAll()
        {
            _cartService.RemoveAll();
            return RedirectToAction("Details");
        }

        public IActionResult AddToCart(int id)
        {
            _cartService.AddToCart(id);
            return Json(new { id, message = "Товар добавлен в корзину" });
        }

        public IActionResult GetCartView() => ViewComponent("CartSummary");

        /// <summary>
        /// создание заказа
        /// </summary>
        /// <returns></returns>
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CheckOut(OrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                var orderModel = new CreateOrderDto()
                {
                    OrderViewModel = model,
                    OrderItems = new List<OrderItemDto>()
                };
                foreach (var orderItem in _cartService.TransformCart().Items)
                {
                    // Todo: студентам самостоятельно перенести в OrderItemMapper
                    orderModel.OrderItems.Add(new OrderItemDto()
                    {
                        Id = orderItem.Key.Id,
                        Price = orderItem.Key.Price,
                        Quantity = orderItem.Value
                    });
                }

                var orderResult = _ordersService.CreateOrder(orderModel, User.Identity.Name);

                _cartService.RemoveAll();
                return RedirectToAction("OrderConfirmed", new { orderResult.Id });
            }

            var detailsModel = new OrderDetailsViewModel()
            {
                CartViewModel = _cartService.TransformCart(),
                OrderViewModel = model
            };

            return View("Details", detailsModel);
        }


        public IActionResult OrderConfirmed(int id)
        {
            ViewBag.OrderId = id;
            return View();
        }
    }
}
