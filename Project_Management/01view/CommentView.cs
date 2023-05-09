using Project_Management._02aplication.controllers;
using Project_Management._02aplication.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management._01view
{
    public partial class CommentView : Form
    {
        CommentsController commentsController = new();
        private readonly string admin;
        public CommentView(string admin)
        {
            InitializeComponent();
            this.admin = admin;
            enableButtos();
        }

        private void CommentView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = commentsController.GetComments("SELECT * FROM comments");
            commentsController.Comment = commentsController.GetComments("SELECT * FROM comments")[0];
            MapperFromData();
        }

        private void enableButtos()
        {
            if (admin != "true")
            {
                deleteBt.Enabled = false;
                updateBt.Enabled = false;
            }
        }

        private void MapperFromData()
        {
            label6.Text = commentsController.Comment.Code.ToString();
            cod_TaskTb.Text = commentsController.Comment.TaskCod.ToString();
            contentTb.Text = commentsController.Comment.Content;
        }
        private void MapperToData()
        {
            commentsController.Comment.TaskCod = Convert.ToInt32(cod_TaskTb.Text);
            commentsController.Comment.Content = contentTb.Text;
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = commentsController.Insert();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                CommentView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void UpdateBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = commentsController.Update();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                CommentView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = commentsController.Delete();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                CommentView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
               
                    string columnName = dataGridView1.Columns[row.Cells[1].ColumnIndex].HeaderText;
                    MessageBox.Show("Título de la columna: " + columnName);
                
                commentsController.Comment = new Comment(
                                       Convert.ToInt32(row.Cells["code"].Value),
                                       Convert.ToInt32(row.Cells["TaskCod"].Value),
                                       row.Cells["Content"].Value.ToString());
                MapperFromData();
            }
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            List<Comment> comments = commentsController.GetComments("SELECT * FROM comments WHERE cod = '" + codTb.Text + "'");
            if (comments.Count > 0)
            {
                dataGridView1.DataSource = comments;
                commentsController.Comment = comments[0];
                MapperFromData();
            }
            else
                Alert.ErrorAlert();
        }

        private void ShowAllBt_Click(object sender, EventArgs e)
        {
            CommentView_Load(sender, e);
        }
    }
}

