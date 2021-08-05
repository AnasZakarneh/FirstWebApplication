using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Models
{
    public class Shift
    {
        public int Id { get; set; }

        public int? EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int JobId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }
}
