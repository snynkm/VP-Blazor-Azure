using DataAccess.DbAccess;
using DataAccess.Models.Menu;
using DataAccess.Models.Branch;

namespace DataAccess.Data;

public class MenuData : IMenuData
{
    private readonly ISqlAccess _db;
    public MenuData(ISqlAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<ToppingDTO>> GetToppingsDTO() =>
        _db.LoadData<ToppingDTO, dynamic>("dbo.spGetToppings", new { });

    public async Task<IEnumerable<MenuItemDTO>> GetMenu()
    {
        var menuItems = new List<MenuItemDTO>();

        var result = await _db.LoadData<MenuItemDTO, dynamic>("dbo.spGetCategorySizeSpecial", new { });

        foreach (var item in result.Where(x => x.CategoryId == 1)) // slices
        {
            var mItem = await _db.LoadMultiData<dynamic>("dbo.spGetMenuMultiDataset", new { item.CategoryId, item.SpecialId });
            await _db.AssignData(item, mItem);
            menuItems.Add(mItem);
        }
        foreach (var item in result.Where(x => x.CategoryId == 2))// specials
        {
            var mItem = await _db.LoadMultiData<dynamic>("dbo.spGetMenuMultiDataset", new { item.CategoryId, item.SpecialId });
            await _db.AssignData(item, mItem);
            menuItems.Add(mItem);
        }
        foreach (var item in result.Where(x => x.CategoryId == 3)) // custom
        {
            var mItem = await _db.LoadMultiData<dynamic>("dbo.spGetMenuMultiDataset", new { item.CategoryId, item.SpecialId });
            await _db.AssignData(item, mItem);
            menuItems.Add(mItem);
        }
        return menuItems;
    }

}
