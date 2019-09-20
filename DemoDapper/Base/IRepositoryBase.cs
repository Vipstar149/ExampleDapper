using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.Base
{
    internal interface IRepositoryBase
    {
        List<Models.StaffModel> SearchStaff(string nome);
    }
}
