using DataAccess.DbAccess;
using DataAccess.Models.Branch;
using DataAccess.Models.Customer;
using DataAccess.Models.Order;

namespace DataAccess.Data;

public class OrderData : IOrderData
{
    private readonly ISqlAccess _db;

    public OrderData(ISqlAccess db)
    {
        _db = db;
    }
    public Task<IEnumerable<State>> GetStates() =>
        _db.LoadData<State, dynamic>("dbo.spGetStates", new { });

    public Task<IEnumerable<Branch>> GetBranches() =>
        _db.LoadData<Branch, dynamic>("dbo.spGetBranches", new { });

    public Task<IEnumerable<BranchDTO>> GetBranchesDTO() =>
        _db.LoadData<BranchDTO, dynamic>("dbo.spGetBranchesAndStates", new { });

    public Task<IEnumerable<Guest>> GetGuestsTest() =>
        _db.LoadData<Guest, dynamic>("dbo.spGetGuests", new { });

    public async Task<int> InsertGuestReturnKey(Guest g)
    {
        return await _db.SaveDataKey("dbo.spInsertCustomerGetKey", new
        {
            g.FirstName,
            g.LastName,
            g.Phone,
            g.Email,
            g.AddressLine,
            g.City,
            g.StateId,
            g.Zip
        });
    }

    public async Task<int> InsertOrderReturnKey(Order or)
    {
        return await _db.SaveDataKey("dbo.spInsertOrderGetKey", new
        {
            or.BranchId,
            or.CustomerId,
            or.CustomerType,
            or.DiscountId,
            or.OrderType,
            or.PaymentType,
            or.Date,
            or.Subtotal,
            or.Tax,
            or.Total,
            or.StatusId
        });
    }

    public async Task InsertMenuItemOrder(List<MenuItemOrder> MIOs)
    {
        foreach (var mio in MIOs)
        {
            await _db.SaveData("dbo.spInsertMenuItemOrder", mio);
        }
    }
    public async Task InsertMenuItemOrderTopping(List<MenuItemOrderTopping> MIOTs)
    {
        foreach (var miot in MIOTs)
        {
            await _db.SaveData("dbo.spInsertMenuItemOrderTopping", miot);
        }
    }


}
