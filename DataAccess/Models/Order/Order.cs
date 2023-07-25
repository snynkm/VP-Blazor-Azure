using DataAccess.Services;
using System.ComponentModel.DataAnnotations;
using VpBlazorApp;

namespace DataAccess.Models.Order;

public class Order
{

    public int Id { get; set; }


    public int BranchId { get; set; }



    public int CustomerId { get; set; }



    public char CustomerType { get; set; }



    public int? DiscountId { get; set; }



    public char? OrderType { get; set; }
    
    
    
    public int PaymentType { get; set; }
    
    
    
    public DateTime Date { get; set; }
    
    
    
    public decimal? Subtotal { get; set; }
    
    
    
    public decimal Tax { get; set; }
    
    
    
    public decimal Total { get; set; }
    
    
    
    public int StatusId { get; set; }

    public Order()
    {
        PaymentType = 1;
        Tax = 0.08m;
    }

    public Order(OrderState os, int cId)
    {
        BranchId = os.OrderItem.BranchId;
        CustomerId = cId;
        switch (os._isGuest)
        {
            case true:
                CustomerType = 'G';
                break;
            case false:
                CustomerType = 'U';
                break;
        }
        DiscountId = os.OrderItem.DiscountId;
        switch (os._isCarryout)
        {
            case true:
                OrderType = 'C';
                break;
            case false:
                OrderType = 'D';
                break;
        }
        PaymentType = os.OrderItem.PaymentType;
        Date = DateTime.Now;
        Subtotal = os.CartSubtotal;
        Tax = (decimal)os.CartTax;
        Total = (decimal)os.CartTotal;
        StatusId = 1;
    }
}

