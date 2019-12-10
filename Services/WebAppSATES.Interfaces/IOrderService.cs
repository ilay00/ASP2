using System.Collections.Generic;
using WebAppSATES.Domain.Entities;
using WebAppSATES.Models;

namespace WebAppSATES.Infrastructure.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> GetUserOrders(string UserName);

        Order GetOrderById(int id);

        Order CreateOrder(OrderViewModel OrderModel, CartViewModel CartModel, string UserName);
    }
}
