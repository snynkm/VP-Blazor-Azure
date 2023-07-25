using DataAccess.Models.Branch;
using DataAccess.Models.Customer;
using DataAccess.Models.Order;

namespace DataAccess.Data
{
    public interface IOrderData
    {
        Task<IEnumerable<Branch>> GetBranches();
        Task<IEnumerable<Guest>> GetGuestsTest();
        Task<IEnumerable<State>> GetStates();
        Task<IEnumerable<BranchDTO>> GetBranchesDTO();
        Task<int> InsertGuestReturnKey(Guest g);
        Task<int> InsertOrderReturnKey(Order or);
        Task InsertMenuItemOrder(List<MenuItemOrder> MIOs);
        Task InsertMenuItemOrderTopping(List<MenuItemOrderTopping> MIOTs);
    }
}