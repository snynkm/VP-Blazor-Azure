using DataAccess.Models.Branch;
using DataAccess.Models.Menu;

namespace DataAccess.Data;

public interface IMenuData
{
    Task<IEnumerable<MenuItemDTO>> GetMenu();
    Task<IEnumerable<ToppingDTO>> GetToppingsDTO();
}