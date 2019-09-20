using Dapper;
using DemoDapper.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.DapperCache
{
    public class ListCrud:IListCrud
    {
        public List<StaffModel> GetAllLists()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;pwd=123456;database=demo_dapper;sslmode=none;charset=utf8;"))
            {
                //    _db = new MySqlConnection("server=localhost;user id=root;pwd=123456;database=demo_dapper;sslmode=none;charset=utf8;");

                return connection.Query<StaffModel>("SELECT * FROM demo_dapper.staff").AsList();
            }
        }
    }
   
}
