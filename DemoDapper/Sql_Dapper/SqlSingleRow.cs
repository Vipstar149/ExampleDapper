using Dapper;
using DemoDapper.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.Sql_Dapper
{
    public class SqlSingleRow
    {
        public StaffModel TopStaff(IDbConnection _db)
        {
            StaffModel staff = new StaffModel();
            using (var connection = _db)
            {
                var sql = "select * from demo_dapper.staff where id = 1";
                staff = connection.QuerySingle<StaffModel>(sql);
            }
            return staff;
        }
        public async Task<List<StaffModel>> StaffAsync(IDbConnection _db)
        {

            var sql = "select * from demo_dapper.staff ";
            var staff = await _db.QueryAsync<StaffModel>(sql);
            return await Task.FromResult(staff.ToList());

        }

    }
}
