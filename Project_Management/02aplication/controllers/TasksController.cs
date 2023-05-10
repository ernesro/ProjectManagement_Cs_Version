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
    

    internal class TasksController
    {
        public Task_ Task { get; set; }
        public TasksController() { Task = new(); }
        public List<Task_> GetTasks(string sql)
        {
            List<Task_> list = new List<Task_>();
            DataTable dt = BaseDatos.Consulta(sql);
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                list.Add(new Task_(int.Parse(dt.Rows[i]["cod"].ToString()),
                                   int.Parse(dt.Rows[i]["cod_proyect"].ToString()),
                                   dt.Rows[i]["title"].ToString(),
                                   dt.Rows[i]["description"].ToString(),
                                   dt.Rows[i]["state"].ToString()));
            }
            return (list);
        }
        public int Insert()
        {
            return BaseDatos.Modificacion("insert into tasks (cod_proyect, title, description, state) values " +
                "('" + Task.ProjectCod + "', '" + Task.Title + "', '" + Task.Description + "', '" + Task.State + "')");
        }
        public int Delete()
        {
            return BaseDatos.Modificacion("delete from tasks where cod = '" + Task.Code + "'");
        }
        public int Update()
        {
            string sql = "select * from tasks where cod = '" + Task.Code + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "update tasks set cod_proyect = '" + Task.ProjectCod + "', title = '" + Task.Title + "', description = '" + Task.Description +
                    "', state = '" + Task.State + "' where cod = '" + Task.Code + "'";
                return (BaseDatos.Modificacion(sql));
            }
            return -1;
        }
    }
}

