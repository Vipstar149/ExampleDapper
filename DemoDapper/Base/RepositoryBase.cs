using Dapper;
using DemoDapper.Code;
using DemoDapper.Models;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.Base
{
    public class RepositoryBase : IRepositoryBase
    {
        private readonly IDbConnection _db;

        public RepositoryBase()
        {
        }
        //public RepositoryBase(IConfiguration configuration)
        //{
        //    //_db = new MySqlConnection("server=localhost;user id=root;pwd=123456;database=demo_dapper;sslmode=none;charset=utf8;");
        //    _db = new MySqlConnection("server=localhost;user id=root;pwd=123456;database=demo_dapper;sslmode=none;charset=utf8;");
        //}
        public RepositoryBase(IOptions<ConnectionStringList> connectionStrings)
        {
            _db = new MySqlConnection(connectionStrings.Value.ConnectionString1);
        }
        public IDbConnection ConnectDB (IOptions<ConnectionStringList> connectionStrings)
        {
            IDbConnection conn = new  MySqlConnection(connectionStrings.Value.ConnectionString1);
            return conn;

        }
        public void Dispose()
        {
            _db.Close();
        }
        public List<StaffModel> SearchStaff(string nome)
        {

            nome = nome.Trim();
            return _db.Query<StaffModel>("SELECT * FROM demo_dapper.staff").ToList();
        }
        public int TotalStaff()
        {
            // Thực thi câu lệnh vô hướng  (Scalar)
            var sql = "select count(*) from demo_dapper.staff";
            var count = _db.ExecuteScalar(sql);
            return Convert.ToInt32(count);
        }
        //Asynchronous Operations -- Không đồng bộ

        public async Task<int> AsynTotalStaffAsync()
        {
            // Thực thi câu lệnh vô hướng  (Scalar)
            var sql = "select count(*) from demo_dapper.staff";
            var count = await _db.ExecuteScalarAsync<int>(sql);          
            return Convert.ToInt32(count);
        }

    }
}
