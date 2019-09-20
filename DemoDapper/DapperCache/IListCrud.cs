using DemoDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.DapperCache
{
    public interface IListCrud
    {
        List<StaffModel> GetAllLists();
    }
}
