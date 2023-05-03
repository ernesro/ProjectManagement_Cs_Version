using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication
{
    using BaseDatos._03data;
    internal class EmployeesController
    {
        public Employee employee { get; set; }
        public EmployeesController() { employee = new Employee(); }

        public List<Employee> GetEmployees(string sql) 
        {
            List<Employee> list = new List<Employee>();
            DataTable dt = BaseDatos.Consulta(sql);
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                list.Add(new Employee(int.Parse(dt.Rows[i]["cod"].ToString()), dt.Rows[i]["dni"].ToString(), dt.Rows[i]["name"].ToString(),
                dt.Rows[i]["lastName"].ToString(), dt.Rows[i]["address"].ToString(), dt.Rows[i]["email"].ToString(), dt.Rows[i]["phoneNumber"].ToString(), 
                dt.Rows[i]["admin"].ToString(), dt.Rows[i]["password"].ToString()));
            }
            return (list);
        }
    }

}
