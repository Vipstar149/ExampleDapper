using Microsoft.AspNetCore.Mvc;
using DemoDapper.Base;
using DemoDapper.Code;
using Microsoft.Extensions.Options;
using System.Data;
using DemoDapper.Sql_Dapper;

namespace DemoDapper.Controllers
{
    public class StaffController : Controller
    {
        public RepositoryBase _repository;
        
        private readonly IDbConnection _db;
        //public StaffController(IConfiguration configuration)
        //{
        //    _repository = new RepositoryBase(configuration);


        public StaffController(IOptions<ConnectionStringList> connectionStrings)
        {
            _repository = new RepositoryBase(connectionStrings);
            _db = new RepositoryBase().ConnectDB(connectionStrings);
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ShowStaff()
        {
            var staff = _repository.SearchStaff(string.Empty);
            var ex1 = _repository.TotalStaff();
            var ex2 = _repository.AsynTotalStaffAsync();
            var ex3 = new SqlExecutingNoQuery().InsertDepartmentAsync(_db);
            var ex4 = new SqlSingleRow().StaffAsync(_db);
            string strID = "1";
            var ex5 = new SqlParameters().SearchDepartment(_db,strID);
            var ex6 = new SqlExecutingNoQuery().StoreProcAsync(_db);

            return View(staff);
        }

        
       
    }
}