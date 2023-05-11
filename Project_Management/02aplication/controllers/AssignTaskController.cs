using Project_Management._02aplication.objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.controllers
{
    using BaseDatos._03data;
    using System.Data;
    internal class AssignTaskController
    {
        public EmployeesController EmployeeController { get; set; }
        public TasksController TaskController { get; set; }
        public AssignedTask AssignedTask { get; set; }
        public AssignTaskController()
        {
            AssignedTask = new AssignedTask();
            EmployeeController = new EmployeesController();
            TaskController = new TasksController();
        }
        public List<AssignedTask> GetAssignedTasks(string sql)
        {
            List<AssignedTask> list = new List<AssignedTask>();
            DataTable dt = BaseDatos.Consulta(sql);
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                list.Add(new AssignedTask(int.Parse(dt.Rows[i]["cod_task"].ToString()),
                                          int.Parse(dt.Rows[i]["cod"].ToString())));
            }
            return (list);
        }
        public List<Employee> GetEmployees(string sql) { return EmployeeController.GetEmployees(sql); }
        public List<Task_> GetTasks(string sql) { return TaskController.GetTasks(sql); }
        public int Insert()
        {
            return BaseDatos.Modificacion("insert into assigntask (cod, cod_task) values " +
                               "('" + EmployeeController.employee.Cod + "', '" + TaskController.Task.Code + "')");
        }
        public int Delete()
        {
            return BaseDatos.Modificacion("delete from assigntask where cod = '" + EmployeeController.employee.Cod + "' and cod_task = '" + TaskController.Task.Code + "'");
        }
    }
}

