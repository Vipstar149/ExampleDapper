using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDapper.Models
{
    public class StaffModel
    {
        public int Id { get; set; }
        public string StaffName { get; set; }
        public string StaffPhone { get; set; }
        public string StaffPosition { get; set; }
        public Nullable<int> DepartmentId { get; set; }

        public DepartmentModel Department { get; set; }

    }
}
