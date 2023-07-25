using DataAccess.Models.Menu;

namespace DataAccess.Models.Order;

public class CartItemDTO
{
    public int? MenuItemId { get; set; }
    public int? OrderLineId { get; set; }
    public string? CategoryName { get; set; }
    public string? SizeName { get; set; }
    public string? SpecialName { get; set; }
    public int Quantity { get; set; }
    public decimal? Price { get; set; }
    public List<Topping>? Toppings { get; set; }

    public string? UrlExtension { get; set; }

    public CartItemDTO()
    {
        
    }
    public CartItemDTO(int? mId, int? olid, string cName, string szName, string spName, int qty, decimal? price, string url, List<ToppingDTO> tps)
    {
        MenuItemId = mId;
        OrderLineId = olid;
        CategoryName = cName;
        SizeName = szName;
        SpecialName = spName;
        Quantity = qty;
        Price = price;
        Toppings = new();
        UrlExtension = url;

        foreach (var tp in tps)
        {
            Toppings.Add(new Topping(tp.Id, tp.Name, tp.PriceMod));
        };
    }
 
}
