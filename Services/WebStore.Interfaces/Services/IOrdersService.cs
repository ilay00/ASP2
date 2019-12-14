using System.Collections.Generic;
using WebStore.DomainNew.Dto.Order;
namespace WebStore.Interfaces.Services
{
    public interface IOrdersService
    {
        IEnumerable<orderDto> GetUserOrders(string userName);
        orderDto GetOrderById(int id);
       orderDto CreateOrder(CreateOrderDto createOrderDto, string userName);
    }
}
