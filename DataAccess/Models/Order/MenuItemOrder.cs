namespace DataAccess.Models.Order;

public class MenuItemOrder
{   
    public int? OrderLineId { get; set; }
    public int OrderId { get; set; }
    public int? MenuItemId { get; set; }
    public int Quantity { get; set; }


    public MenuItemOrder()
    {
        
    }
    public MenuItemOrder( int? olId, int orId, int? mId, int qty)
    {
        OrderLineId = olId;
        OrderId = orId;
        MenuItemId = mId;
        Quantity = qty;
    }

}
