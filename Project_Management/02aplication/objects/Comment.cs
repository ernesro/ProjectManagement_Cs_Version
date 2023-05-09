using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.objects
{
    internal class Comment
    {
        public int Code { get; set; }
        public int TaskCod { get; set; }
        public string Content { get; set; }
        public Comment() { }
        public Comment(int code, int taskCod, string content) 
        {
            Code = code;
            TaskCod = taskCod;
            Content = content;
        }
    }
}
