namespace DataAccess.Models.Order;

public class MenuItemOrderTopping
{
    public int? OrderLineId { get; set; }
    public int OrderId { get; set; }
    public int? ToppingId { get; set; }

    public MenuItemOrderTopping()
    {
        
    }

    public MenuItemOrderTopping(int? olId, int orId, int? tpId)
    {
        OrderLineId = olId;
        OrderId = orId;
        ToppingId = tpId;
    }
}

