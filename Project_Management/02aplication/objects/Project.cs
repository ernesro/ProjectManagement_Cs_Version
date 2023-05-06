using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.objects
{
    internal class Project
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public Project() { }
        public Project(int code, string title, string description, string state)
        {
            Code = code;
            Title = title;
            Description = description;
            State = state;
        }
    }
}
