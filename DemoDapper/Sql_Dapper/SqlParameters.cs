using Dapper;
using DemoDapper.Code;
using DemoDapper.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
namespace DemoDapper.Sql_Dapper
{
    public class SqlParameters
    {
        public async Task<List<DepartmentModel>>  SearchDepartment(IDbConnection _db,string strId)
        {
            var parameters = new { Id = strId  };
            var sql = "select * from demo_dapper.department where Id = @Id";
            var result = await _db.QueryAsync<DepartmentModel>(sql, parameters);
            return await Task.FromResult(result.ToList());
        }

    }
}
