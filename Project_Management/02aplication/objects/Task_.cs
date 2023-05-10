using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.objects
{
    internal class Task_
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public int ProjectCod { get; set; }
        public string Description { get; set; }
        public string State { get; set; }
        public Task_() { }
        public Task_(int code, int projectCod, string description, string title, string state)
        {
            Code = code;
            ProjectCod = projectCod;
            Description = description;
            Title = title;
            State = state;
        }
    }
}
