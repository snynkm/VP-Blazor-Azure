using DataAccess.Models.Customer;
using DataAccess.Models.Order;
using System.Linq;
using VpBlazorApp;

namespace DataAccess.Services;

public class OrderService : IOrderService
{
    private readonly IOrderGen _og;

    public OrderService(IOrderGen og)
    {
        _og = og;
    }

    public Task<Order> CreateOrder() =>
        _og.CreateObject<Order>();

    public Task<Customer> CreateCustomer() =>
        _og.CreateObject<Customer>();

    public Task<MenuItemOrder> CreateOrderLineItem() =>
        _og.CreateObject<MenuItemOrder>();

    public Task<MenuItemOrderTopping> CreateOrderLineToppingItem() =>
        _og.CreateObject<MenuItemOrderTopping>();

    public Task<Guest> ConvertToGuest(Customer c)
    {
        Guest guest = new(c.FirstName, c.LastName, c.Phone, c.Email, c.AddressLine, c.City, c.StateId, c.Zip);
        return Task.FromResult(guest);
    }

    public Task<Order> BuildOrder(OrderState os, int cId)
    {
        Order order = new(os, cId);
        return Task.FromResult(order);
    }
    
    public Task<List<MenuItemOrder>> BuildMenuItemOrder (IEnumerable<CartItemDTO> cItems, int orId)
    {
        List<MenuItemOrder> menuItemOrder = new();
        foreach (var item in cItems)
        {
            menuItemOrder.Add(new (item.OrderLineId, orId, item.MenuItemId, item.Quantity));
        }
        return Task.FromResult(menuItemOrder);
    }

    public Task<List<MenuItemOrderTopping>> BuildMenuItemOrderTopping (IEnumerable<CartItemDTO> cItems, int orId)
    {
        List<MenuItemOrderTopping> menuItemOrderToppings = cItems
            .SelectMany(item => item.Toppings?.Select(tp => new MenuItemOrderTopping(item.OrderLineId, orId, tp.Id)) ?? Enumerable.Empty<MenuItemOrderTopping>())
            .ToList();

        return Task.FromResult(menuItemOrderToppings);
    }
}
