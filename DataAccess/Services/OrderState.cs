using DataAccess.Models.Customer;
using DataAccess.Models.Order;

namespace VpBlazorApp;

public class OrderState
{
    public List<CartItemDTO>? CartItems { get; set; }
    public Order? OrderItem { get; set; }
    public Customer? Customer { get; set; }

    public bool _InitialiNotice { get; set; } = true;
    public bool _IsOrderSuccess { get; set; } = false;


    public decimal? CartSubtotal =>
        CartItems?.Sum(x => (x.Price + x.Toppings?.Sum(x => x.PriceMod)) * x.Quantity);

    public decimal? CartTax => Math.Round((decimal)(OrderItem.Tax * CartSubtotal), 2);

    public decimal? CartTotal => CartSubtotal + Math.Round((decimal)CartTax, 2);



    /* Is Cart Full */
    public bool _isCartEmpty => //{ get; set; } = true;
        CartItems?.Count == 0;

    /*  Is Guest Account:   N(0): Guest | Y(1): Existing User */
    public bool? _isGuest { get; set; } = null;
    /* Is Account Type selected */
    public bool? _isAccountTypeSelected => _isGuest != null;

    /*  Order Type:  N(0) - Carryout | (1) - Delivery */
    public bool? _isCarryout { get; set; } = null;
    /* Is Order Type selected */
    public bool? _isOrderTypeSelected => _isCarryout != null;

    public event Action OnStateChange;

    public OrderState()
    {
        CartItems = new();
        Customer = new();
        OrderItem = new();
    }

    private async Task BuildCustomer()
    {

    }

    private async Task NotifyStateChanged() =>
        OnStateChange?.Invoke();

    public async Task SetCartFull() =>
        await NotifyStateChanged();

    public async Task SetCartEmpty() =>
        await NotifyStateChanged();

    public async Task SetGuestTrue()
    {
        _isGuest = true;
        await NotifyStateChanged();
    }

    public async Task SetGuestFalse()
    {
        _isGuest = false;
        await NotifyStateChanged();
    }

    public async Task SetCarryoutTrue()
    {
        _isCarryout = true;
        await NotifyStateChanged();
    }

    public async Task SetCarryoutFalse()
    {
        _isCarryout = false;
        await NotifyStateChanged();
    }

    public async Task SetPaymentCash()
    {
        OrderItem.PaymentType = 1;
        await NotifyStateChanged();
    }
    public async Task SetPaymentCredit()
    {
        OrderItem.PaymentType = 2;
        await NotifyStateChanged();
    }
    public async Task ResetCart()
    {
        CartItems.Clear();
        await NotifyStateChanged();
    }
    public async Task SetOrderSuccessTrue()
    {
        _IsOrderSuccess = true;
        await NotifyStateChanged();
    }
}
