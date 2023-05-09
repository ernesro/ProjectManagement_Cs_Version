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

    internal class CommentsController
    {
        public Comment Comment { get; set; }
        public CommentsController() { Comment = new(); }
        public List<Comment> GetProjects(string sql)
        {
            List<Comment> list = new List<Comment>();
            DataTable dt = BaseDatos.Consulta(sql);
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                list.Add(new Comment(int.Parse(dt.Rows[i]["cod"].ToString()),
                                     int.Parse(dt.Rows[i]["cod_task"].ToString()),
                                               dt.Rows[i]["content"].ToString()));
            }
            return (list);
        }
        public int Insert()
        {
            return BaseDatos.Modificacion("insert into comments (cod_task, content) values " +
                "('" + Comment.TaskCod + "', '" + Comment.Content + "')");
        }
        public int Delete()
        {
            return BaseDatos.Modificacion("delete from comments where cod = '" + Comment.Code + "'");
        }
        public int Update()
        {
            string sql = "select * from comments where cod = '" + Comment.Code + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "update comments set cod_task = '" + Comment.TaskCod + "', content = '" + Comment.Content + "'";
                return (BaseDatos.Modificacion(sql));
            }
            return -1;
        }
    }
}
