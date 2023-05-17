using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication
{
    using BaseDatos._03data;
    using System.Text.RegularExpressions;

    internal class EmployeesController
    {
        public Employee employee { get; set; }
        public EmployeesController() { employee = new Employee(); }

        public string Error() { return BaseDatos.Error; }

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

        public int InsertEmployee()
        {
            return BaseDatos.Modificacion("insert into employees (dni, name, lastName, address, email, phoneNumber, admin) values ('"
                   + employee.Dni + "', '" + employee.Name + "', '" + employee.LastName + "', '"
                   + employee.Address + "', '" + employee.Email + "', '" + employee.PhoneNumber + "', '"
                   + employee.Admin + "')");
        }

        public int DeleteEmployee()
        {
            return BaseDatos.Modificacion("delete from employees where dni = '" + employee.Dni + "'");
        }

        public int UpdateEmployee()
        {
            string sql = "select * from employees where dni = '" + employee.Dni + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "update employees set dni = '" + employee.Dni + "', name = '"
                + employee.Name + "', lastName = '" + employee.LastName + "', address = '"
                + employee.Address + "', email = '" + employee.Email + "', phoneNumber = '"
                + employee.PhoneNumber + "', admin = '" + employee.Admin + "' where dni = '" + employee.Dni + "'";
                return (BaseDatos.Modificacion(sql));
            }
            return -1;
        }
    }
}
