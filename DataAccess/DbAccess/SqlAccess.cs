using Dapper;
using DataAccess.Models.Menu;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccess.DbAccess;
public class SqlAccess : ISqlAccess
{

    private readonly IConfiguration _config;
    public SqlAccess(IConfiguration config) => this._config = config;


    // Return IEnumerable Data
    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storedProcedure, 
        U parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        return await connection.QueryAsync<T>(
            storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure);
    }

    // Return IEnumerable based on Multiple Tables
    public async Task<MenuItemDTO> LoadMultiData<U>(
    string storedProcedure, //MenuDataSetLists
    U parameters,
    string connectionId = "Default")
    {
        using DbConnection cn = new SqlConnection(_config.GetConnectionString(connectionId));

        MenuItemDTO obj = new();

        using (var multi = await cn.QueryMultipleAsync(
            storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure))
        {
            obj = new MenuItemDTO()
            {
                MenuItemIds = await multi.ReadAsync<int>(),
                SizeIds = await multi.ReadAsync<int>(),
                SizeNames = await multi.ReadAsync<string>(),
                Prices = await multi.ReadAsync<decimal>()
            };
            return obj;
        }
    }

    public Task<MenuItemDTO> AssignData(MenuItemDTO input, MenuItemDTO output)
    {
        output.CategoryId = input.CategoryId;
        output.CategoryName = input.CategoryName;
        output.CategoryDescription = input.CategoryDescription;
        output.SpecialId = input.SpecialId;
        output.SpecialName = input.SpecialName;
        output.SpecialDescription = input.SpecialDescription;
        output.UrlExtension = input.UrlExtension;
        return Task.FromResult(output);

    }

    // Insert Data
    public async Task SaveData<T>(
        string storedProcedure,
        T parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        await connection.ExecuteAsync(storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure);

    }

    // Insert Data and Return Generated PK
    public async Task<int> SaveDataKey<T>(
        string storedProcedure,
        T parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        return await connection.QueryFirstOrDefaultAsync<int>(storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure);
    }

}



