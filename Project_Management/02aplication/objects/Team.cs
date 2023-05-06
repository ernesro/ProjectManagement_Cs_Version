using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication
{
    internal class Team
    {
        public int Code { get; set; }
        public string Name { get; set; }

        public Team() { }
        public Team(int code, string name) { Code = code; Name = name; }
    }
}
