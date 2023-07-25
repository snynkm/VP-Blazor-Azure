using DataAccess.Models;
using DataAccess.Models.Menu;

namespace DataAccess.DbAccess;

public interface ISqlAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default");
    Task<MenuItemDTO> LoadMultiData<U>(string storedProcedure, U parameters, string connectionId = "Default");
    Task<MenuItemDTO> AssignData(MenuItemDTO inputItem, MenuItemDTO outputItem);
    Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "Default");
    Task<int> SaveDataKey<T>(string storedProcedure, T parameters, string connectionId = "Default");
}


