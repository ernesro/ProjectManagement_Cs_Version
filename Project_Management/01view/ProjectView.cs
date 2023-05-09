using Project_Management._02aplication;
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
    public partial class ProjectView : Form
    {
        ProjectController projectController = new();
        private readonly string admin;
        public ProjectView(string admin)
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.admin = admin;
            enableButtos();
        }

        private void enableButtos()
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
            codeLb.Text = projectController.Project.Code.ToString();
            titleTb.Text = projectController.Project.Title;
            descriptionTb.Text = projectController.Project.Description;
            stateLb.Text = projectController.Project.State;
        }
        private void MapperToData()
        {
            projectController.Project.Title = titleTb.Text;
            projectController.Project.Description = descriptionTb.Text;
            projectController.Project.State = stateLb.Text;
        }

        private void ProjectView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = projectController.GetProjects("SELECT * FROM proyects");
            projectController.Project = projectController.GetProjects("SELECT * FROM proyects")[0];
            MapperFromData();
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = projectController.Insert();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                ProjectView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void UpdateBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = projectController.Update();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                ProjectView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = projectController.Delete();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                ProjectView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                projectController.Project = new Project(
                                       Convert.ToInt32(row.Cells["Code"].Value),
                                       row.Cells["title"].Value.ToString(),
                                       row.Cells["description"].Value.ToString(),
                                       row.Cells["state"].Value.ToString());
                MapperFromData();
            }
        }

        private void SearchBt_Click(object sender, EventArgs e)
        {
            List<Project> projects = projectController.GetProjects("SELECT * FROM proyects WHERE cod = '" + codTb.Text + "'");
            if (projects.Count > 0)
            {
                dataGridView1.DataSource = projects;
                projectController.Project = projects[0];
                MapperFromData();
            }
            else
                Alert.ErrorAlert();
        }

        private void progressBt_Click(object sender, EventArgs e) { stateLb.Text = "in progress"; }
        private void completedBt_Click(object sender, EventArgs e) { stateLb.Text = "completed"; }
        private void onHoldBt_Click(object sender, EventArgs e) { stateLb.Text = "on hold"; }

        private void searchByName_Click(object sender, EventArgs e)
        {
            List<Project> projects = projectController.GetProjects("SELECT * FROM proyects WHERE title = '" + titleTb.Text + "'");
            if (projects.Count > 0)
            {
                dataGridView1.DataSource = projects;
                projectController.Project = projects[0];
                MapperFromData();
            }
            else
                Alert.ErrorAlert();
        }

        private void showAllBt_Click(object sender, EventArgs e)
        {
            ProjectView_Load(sender, e);
        }
    }
}
