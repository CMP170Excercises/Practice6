using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementWithWS.Controllers.Models
{
    public class TestStudentWS
    {
        public int studentId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string Class { get; set; }
        public decimal gpa { get; set; }
    }
}
