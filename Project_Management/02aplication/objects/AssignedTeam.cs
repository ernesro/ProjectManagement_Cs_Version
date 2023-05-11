using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.objects
{
    internal class AssignedTeam
    {
        public int CodTeam { get; set; }
        public int CodProyect { get; set; }
        public AssignedTeam() { }
        public AssignedTeam(int codTeam, int codProyect)
        {
            CodTeam = codTeam;
            CodProyect = codProyect;
        }
    }
}
