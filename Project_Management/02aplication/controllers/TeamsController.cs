using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.controllers
{
    using BaseDatos._03data;
    internal class TeamsController
    {
        public Team Team { get; set; }
        public TeamsController() { Team = new(); }

        public List<Team> GetTeams(string sql)
        {
            List<Team> list = new List<Team>();
            DataTable dt = BaseDatos.Consulta(sql);
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                list.Add(new Team(int.Parse(dt.Rows[i]["cod"].ToString()), dt.Rows[i]["name"].ToString()));
            }
            return (list);
        }

        public int Insert()
        {
            return BaseDatos.Modificacion("insert into teams (name) values ('" + Team.Name + "')");
        }

        public int Delete()
        {
            return BaseDatos.Modificacion("delete from teams where cod = '" + Team.Code + "'");
        }

        public int Update()
        {
            string sql = "select * from teams where cod = '" + Team.Code + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "update teams set name = '" + Team.Name + "' where cod = '" + Team.Code + "'";
                return (BaseDatos.Modificacion(sql));
            }
            return -1;
        }


    }

}

