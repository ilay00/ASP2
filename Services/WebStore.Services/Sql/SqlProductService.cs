using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebStore.DAL;

using WebStore.DomainNew.Dto.Order;

using WebStore.DomainNew.Entities;
using WebStore.Interfaces.Services;
namespace WebStore.Services.Sql
{
    public class SqlOrdersService : IOrdersService
    {
        private readonly WebStoreContext _context;
        private readonly UserManager<User> _userManager;
        /*  public SqlOrdersService(WebStoreContext context, UserManager<User>
  userManager)
          {
              _context = context;
              _userManager = userManager;
          }*/
       /* public IEnumerable<orderDto> GetUserOrders(string userName)
        {
            return _context.Orders.Include("User").Include("OrderItems").Where(o => o.User.UserName.Equals(userName)).Select(o => new orderDto()
            
            {
                Id = o.Id,
                Name = o.Name,
                Address = o.Address,
                Date = o.Date,
                Phone = o.Phone,
                OrderItems = o.OrderItems.Select(oi => new OrderItemDto()
                {
                    Id = oi.Id,
                    Price = oi.Price,
                    Quantity = oi.Quantity
                })
            }).ToList();
        }*/

        public orderDto GetOrderById(int id)
        {
            var order = _context.Orders.Include("OrderItems").FirstOrDefault(o
          => o.Id.Equals(id));
            if (order == null) return null;
            return new orderDto()
            {
                Id = order.Id,
                Name = order.Name,
                Address = order.Address,
                Date = order.Date,
                Phone = order.Phone,
                OrderItems = order.OrderItems.Select(oi => new OrderItemDto()
                {
                    Id = oi.Id,
                    Price = oi.Price,
                    Quantity = oi.Quantity
                })
            };
        }
        public orderDto CreateOrder(CreateOrderDto createOrderDto, string userName)
        {
            var user =_userManager.FindByNameAsync(userName).Result;
            using (var transaction =_context.Database.BeginTransaction())
            {
                var order = new Order()
                {
                    Address = createOrderDto.OrderViewModel.Address,
                    Name = createOrderDto.OrderViewModel.Name,
                    Date = DateTime.Now,
                    Phone = createOrderDto.OrderViewModel.Phone,
                    User = user
                };
                _context.Orders.Add(order);
                foreach (var item in createOrderDto.OrderItems)
                {
                    var product =_context.Products.FirstOrDefault(p =>
                    p.Id.Equals(item.Id));
                    if (product == null)
                        throw new InvalidOperationException("Продукт не найден в базе");
                        var orderItem = new OrderItem()
                        {
                            Order = order,
                            Price = product.Price,
                            Quantity = item.Quantity,
                            Product = product
                        };
                    _context.OrderItems.Add(orderItem);
                }
                _context.SaveChanges();
                transaction.Commit();
                return GetOrderById(order.Id);
            }
        }
    }
}