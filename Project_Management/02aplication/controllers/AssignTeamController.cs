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
    internal class AssignTeamController
    {
        public ProjectController ProjectController { get; set; }
        public TeamsController TeamController { get; set; }
        public AssignedTeam AssignedTeam { get; set; }
        public AssignTeamController()
        {
            AssignedTeam = new AssignedTeam();
            ProjectController = new ProjectController();
            TeamController = new TeamsController();
        }
        public List<AssignedTeam> GetAssignedTeam(string sql)
        {
            List<AssignedTeam> list = new List<AssignedTeam>();
            DataTable dt = BaseDatos.Consulta(sql);
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                list.Add(new AssignedTeam(int.Parse(dt.Rows[i]["cod_team"].ToString()),
                                          int.Parse(dt.Rows[i]["cod_proyect"].ToString())));
            }
            return (list);
        }
        public List<Project> GetProject(string sql) { return ProjectController.GetProjects(sql); }
        public List<Team> GetTeams(string sql) { return TeamController.GetTeams(sql); }
        public int Insert()
        {
            return BaseDatos.Modificacion("insert into assignteam (cod_proyect, cod_team) values " +
                               "('" + ProjectController.Project.Code + "', '" + TeamController.Team.Code + "')");
        }
        public int Delete()
        {
            return BaseDatos.Modificacion("delete from assignteam where cod_proyect = '" + ProjectController.Project.Code + "' and cod_team = '" + TeamController.Team.Code + "'");
        }
    }
}

