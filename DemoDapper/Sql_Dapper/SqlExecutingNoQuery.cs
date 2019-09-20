using Dapper;
using DemoDapper.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.Sql_Dapper
{
    public class SqlExecutingNoQuery
    {
        //Không chạy async

        public void InsertDepartment(IDbConnection _db)
        {
            string sql = @"INSERT INTO `demo_dapper`.`department` (`Id`, `DepartmentName`, `DepartmentPhone`) 
                            VALUES ('3', 'HelpIT', '0978123213');";
            _db.Execute(sql);            
        }
        //chạy async -- Dự án EOS đang chạy theo cách này rất nhiều.

        public async Task  InsertDepartmentAsync(IDbConnection _db)
        {
            string sql = @"INSERT INTO `demo_dapper`.`department` (`Id`, `DepartmentName`, `DepartmentPhone`) 
                            VALUES ('3', 'HelpIT', '0978123213');";

            _ = await _db.ExecuteAsync(sql);
        }
        public async Task<List<StaffModel>> StoreProcAsync(IDbConnection _db)
        {
            var sql = "Call STAFF_SRH";            
            var res = await _db.QueryAsync<StaffModel>(sql);
            return await Task.FromResult(res.ToList());
        }
        // Tương tự với insert và update
    }
}
