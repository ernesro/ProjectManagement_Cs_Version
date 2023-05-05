using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Project_Management._02aplication
{
    using BaseDatos._03data;
    using System.Text.RegularExpressions;

    internal class LoginWindowController
    {
        public Employee Employee {get; set;}
        public LoginWindowController() { Employee = new Employee(); }
        public bool IsValidEmail(string email) 
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        public bool Login(string email, string password)
        {
            Employee logedEmployee = GetByMailAndPasswd(email, password);
            if (logedEmployee != null)
            {
                Employee = logedEmployee;
                return true;
            }
            return false;
        }

        public Employee GetByMailAndPasswd(string mail, string passwd)
        {
            DataTable dt = BaseDatos.Consulta("select * from employees where email = '" + mail + "' and password = '" + passwd + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                Employee e = new Employee(Convert.ToInt32(dt.Rows[0]["cod"]), dt.Rows[0]["dni"].ToString(), dt.Rows[0]["name"].ToString(),
                dt.Rows[0]["lastName"].ToString(), dt.Rows[0]["address"].ToString(), dt.Rows[0]["email"].ToString(), dt.Rows[0]["phoneNumber"].ToString(),
                dt.Rows[0]["admin"].ToString(), dt.Rows[0]["password"].ToString());
                return (e);
            }
            return (null);
        }
    }
}
