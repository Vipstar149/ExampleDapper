using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DemoDapper.Models.StaffModel;

namespace DemoDapper.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentPhone { get; set; }

        public List<StaffModel> Staffs { get; set; }
    }
}
