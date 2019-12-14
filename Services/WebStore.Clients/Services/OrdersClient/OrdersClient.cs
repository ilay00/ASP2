using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Dto.Order;
using WebStore.Interfaces.Services;

namespace WebStore.Clients.Services.Orders
{
    public class OrdersClient : BaseClient//, IOrdersService
    {
        public OrdersClient(IConfiguration configuration) : base(configuration)
        {
            ServiceAddress = "api/orders";
        }
        protected sealed override string ServiceAddress { get; set; }
        public IEnumerable<orderDto> GetUserOrders(string userName)
        {
            var url = $" {ServiceAddress} /user/ {userName} ";
            var result = Get<List<orderDto>>(url);
            return result;
        }
        public orderDto GetOrderById(int id)
        {
            var url = $" {ServiceAddress} / {id} ";
            var result = Get<orderDto>(url);
            return result;
        }
        public orderDto CreateOrder(CreateOrderDto createOrderDto, string
        userName)
        {
            var url = $" {ServiceAddress} / {userName} ";
            var response = Post(url, createOrderDto);
            var result = response.Content.ReadAsAsync<orderDto>().Result;
            return result;
        }
    }
}