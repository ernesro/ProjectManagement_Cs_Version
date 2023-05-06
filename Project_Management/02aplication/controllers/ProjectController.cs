using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.controllers
{
    using BaseDatos._03data;
    using Project_Management._02aplication.objects;
    using System.Data;

    internal class ProjectController
    {

        public Project Project { get; set; }
        public ProjectController() { Project = new(); }
        public List<Project> GetProjects(string sql)
        {
            List<Project> list = new List<Project>();
            DataTable dt = BaseDatos.Consulta(sql);
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                list.Add(new Project(int.Parse(dt.Rows[i]["cod"].ToString()), 
                                               dt.Rows[i]["title"].ToString(), 
                                               dt.Rows[i]["description"].ToString(), 
                                               dt.Rows[i]["state"].ToString()));
            }
            return (list);
        }
        public int Insert()
        {
            return BaseDatos.Modificacion("insert into proyects (title, description, state) values " +
                "('" + Project.Title + "', '" + Project.Description + "', '" + Project.State + "')");
        }
        public int Delete()
        {
            return BaseDatos.Modificacion("delete from proyects where cod = '" + Project.Code + "'");
        }
        public int Update()
        {
            string sql = "select * from proyects where cod = '" + Project.Code + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "update proyects set title = '" + Project.Title + "', description = '" + Project.Description +
                    "', state = '" + Project.State + "' where cod = '" + Project.Code + "'";
                return (BaseDatos.Modificacion(sql));
            }
            return -1;
        }
    }
}
