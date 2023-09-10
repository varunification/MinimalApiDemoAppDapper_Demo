using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace DataAccess.DBAccess;
public class SqlDataAccess : ISqlDataAccess
{
    private IConfiguration _config;
    public SqlDataAccess(IConfiguration configuration)
    {
        this._config = configuration;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storedProcedures,
        U parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
        return await connection.QueryAsync<T>(storedProcedures, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task SavaData<U>(string storedProcedures,
        U parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
        await connection.ExecuteAsync(storedProcedures, parameters, commandType: CommandType.StoredProcedure);
    }



}
