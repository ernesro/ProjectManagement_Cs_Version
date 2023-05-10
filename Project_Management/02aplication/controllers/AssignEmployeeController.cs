using Project_Management._02aplication.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.controllers
{
    using BaseDatos._03data;
    using System.Data;

    internal class AssignEmployeeController
    {
        public EmployeesController EmployeeController { get; set; }
        public TeamsController TeamController { get; set; }
        public AssignedEmployee AssignedEmployee { get; set; }
        public AssignEmployeeController()
        {
            AssignedEmployee = new AssignedEmployee();
            EmployeeController = new EmployeesController();
            TeamController = new TeamsController();
        }
        public List<AssignedEmployee> GetAssignedEmployees(string sql)
        {
            List<AssignedEmployee> list = new List<AssignedEmployee>();
            DataTable dt = BaseDatos.Consulta(sql);
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                list.Add(new AssignedEmployee(int.Parse(dt.Rows[i]["cod"].ToString()),
                                              int.Parse(dt.Rows[i]["cod_team"].ToString())));
            }
            return (list);
        }
        public List<Employee> GetEmployees(string sql) { return EmployeeController.GetEmployees(sql); }
        public List<Team> GetTeams(string sql) { return TeamController.GetTeams(sql); }
        public int Insert()
        {
            return BaseDatos.Modificacion("insert into assignemployee (cod, cod_team) values " +
                               "('" + EmployeeController.employee.Cod + "', '" + TeamController.Team.Code + "')");
        }
        public int Delete()
        {
            return BaseDatos.Modificacion("delete from assignemployee where cod = '" + EmployeeController.employee.Cod + "' and cod_team = '" + TeamController.Team.Code + "'");
        }
    }
}
