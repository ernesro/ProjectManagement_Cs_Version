using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.objects
{
    internal class AssignedTask
    {
        public int CodTask { get; set; }
        public int CodEmployee { get; set; }
        public AssignedTask() { }
        public AssignedTask(int codTask, int codEmployee)
        {
            CodTask = codTask;
            CodEmployee = codEmployee;
        }
    }
}
