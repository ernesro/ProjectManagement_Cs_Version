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
    public partial class TaskView : Form
    {
        private readonly string admin;
        TasksController tasksController = new();
        public TaskView(string admin)
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.admin = admin;
            EnableButtos();
        }
        private void EnableButtos()
        {
            if (admin != "true")
            {
                addBt.Enabled = false;
                deleteBt.Enabled = false;
                updateBt.Enabled = false;
                progressBt.Enabled = false;
                holdBt.Enabled = false;
                completedBt.Enabled = false;
            }
        }

        private void MapperFromData()
        {
            codeLb.Text = tasksController.Task.Code.ToString();
            projectLb.Text = tasksController.Task.ProjectCod.ToString();
            titleTb.Text = tasksController.Task.Description;
            descriptionTb.Text = tasksController.Task.Title;
            stateLb.Text = tasksController.Task.State;
        }
        private void MapperToData()
        {
            tasksController.Task.ProjectCod = Convert.ToInt32(projectLb.Text);
            tasksController.Task.Title = titleTb.Text;
            tasksController.Task.Description = descriptionTb.Text;
            tasksController.Task.State = stateLb.Text;
        }

        private void TaskView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tasksController.GetTasks("SELECT * FROM tasks");
            tasksController.Task = tasksController.GetTasks("SELECT * FROM tasks")[0];
            MapperFromData();
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = tasksController.Insert();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                TaskView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void UpdateBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = tasksController.Update();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                TaskView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = tasksController.Delete();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                TaskView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tasksController.Task = new Task_(
                                       Convert.ToInt32(row.Cells["Code"].Value),
                                       Convert.ToInt32(row.Cells["ProjectCod"].Value),
                                       row.Cells["title"].Value.ToString(),
                                       row.Cells["description"].Value.ToString(),
                                       row.Cells["state"].Value.ToString());
                MapperFromData();
            }
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            List<Task_> tasks = tasksController.GetTasks("SELECT * FROM tasks WHERE cod = '" + codTb.Text + "'");
            if (tasks.Count > 0)
            {
                dataGridView1.DataSource = tasks;
                tasksController.Task = tasks[0];
                MapperFromData();
            }
            else
                Alert.ErrorAlert();
        }

        private void progressBt_Click(object sender, EventArgs e) { stateLb.Text = "in progress"; }
        private void completedBt_Click(object sender, EventArgs e) { stateLb.Text = "completed"; }
        private void onHoldBt_Click(object sender, EventArgs e) { stateLb.Text = "not started"; }

        private void searchByName_Click(object sender, EventArgs e)
        {
            List<Task_> tasks = tasksController.GetTasks("SELECT * FROM tasks WHERE cod_proyect = '" + projectLb.Text + "'");
            if (tasks.Count > 0)
            {
                dataGridView1.DataSource = tasks;
                tasksController.Task = tasks[0];
                MapperFromData();
            }
            else
                Alert.ErrorAlert();
        }

        private void showAllBt_Click(object sender, EventArgs e)
        {
            TaskView_Load(sender, e);
        }
    }
}

