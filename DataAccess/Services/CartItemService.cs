using DataAccess.Models.Menu;
using DataAccess.Models.Order;

namespace DataAccess.Services;

public class CartItemService : ICartItemService
{
    public CartItemDTO CartItem { get; private set; }
    public CartItemService()
    {
        CartItem = new();
    }

    public Task<CartItemDTO> GetNewCartItem()
    {
        CartItem = new();
        return Task.FromResult(CartItem);
    }

    public Task<CartItemDTO> AddCartItem(int? mId, int? olid, MenuItemDTO mItem, string szName, int qty, decimal? price, List<ToppingDTO> tps)
    {
        CartItemDTO cartItem = new(mId, olid, mItem.CategoryName, szName, mItem.SpecialName, qty, price, mItem.UrlExtension, tps); 

        return Task.FromResult(cartItem);
    }

}
