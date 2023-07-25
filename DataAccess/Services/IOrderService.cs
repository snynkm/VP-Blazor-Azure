using DataAccess.Models.Customer;
using DataAccess.Models.Order;
using VpBlazorApp;

namespace DataAccess.Services
{
    public interface IOrderService
    {
        Task<Customer> CreateCustomer();
        Task<MenuItemOrderTopping> CreateOrderLineToppingItem();
        Task<Order> CreateOrder();
        Task<MenuItemOrder> CreateOrderLineItem();
        Task<Guest> ConvertToGuest(Customer cstm);
        Task<Order> BuildOrder(OrderState os, int cId);
        Task<List<MenuItemOrder>> BuildMenuItemOrder(IEnumerable<CartItemDTO> cItems, int orId);
        Task<List<MenuItemOrderTopping>> BuildMenuItemOrderTopping(IEnumerable<CartItemDTO> cItems, int orId);


        /*Task BuildCustomer<T>(T obj, params object[] parameters);*/
    }
}