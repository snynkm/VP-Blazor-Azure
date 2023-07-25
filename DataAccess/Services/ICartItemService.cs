using DataAccess.Models.Menu;
using DataAccess.Models.Order;

namespace DataAccess.Services
{
    public interface ICartItemService
    {
        CartItemDTO CartItem { get; }

        Task<CartItemDTO> AddCartItem(int? mId, int? olid, MenuItemDTO mItem, string szName, int qty, decimal? price, List<ToppingDTO> tps);
        Task<CartItemDTO> GetNewCartItem();
    }
}