using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.objects
{
    internal class AssignedEmployee
    {
        public int EmployeeCod { get; set; }
        public int TaskCod { get; set; }
        public AssignedEmployee() { }
        public AssignedEmployee(int employeeCod, int taskCod)
        {
            EmployeeCod = employeeCod;
            TaskCod = taskCod;
        }
    }
}
