using Project_Management._02aplication.controllers;
using Project_Management._02aplication.objects;
using Project_Management._02aplication;
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
    public partial class AssignTeamView : Form
    {
        private string admin;
        private readonly AssignTeamController assignTeamController = new();
        public AssignTeamView(string admin)
        {
            InitializeComponent();
            this.admin = admin;
            EnableButtons();
            projectsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            assignGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            teamGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void EnableButtons()
        {
            if (admin != "true")
            {
                addBt.Enabled = false;
                deleteBt.Enabled = false;
            }
        }

        private void AssignEmployeeView_Load(object sender, EventArgs e)
        {
            assignGrid.DataSource = assignTeamController.GetAssignedTeam("SELECT * FROM assignteam");
            projectsGrid.DataSource = assignTeamController.GetProject("SELECT * FROM proyects");
            teamGrid.DataSource = assignTeamController.GetTeams("SELECT * FROM teams");
            assignTeamController.ProjectController.Project = assignTeamController.ProjectController.GetProjects("SELECT * FROM proyects")[0];
            assignTeamController.TeamController.Team = assignTeamController.TeamController.GetTeams("SELECT * FROM teams")[0];


            MapperFromData();
        }

        private void MapperFromData()
        {
            projectTb.Text = assignTeamController.ProjectController.Project.Code.ToString();
            teamTb.Text = assignTeamController.TeamController.Team.Code.ToString();
        }
        private void MapperToData()
        {
            assignTeamController.ProjectController.Project = assignTeamController.ProjectController.GetProjects("SELECT * FROM proyects WHERE cod = '" + projectTb.Text + "'")[0];
            assignTeamController.TeamController.Team = assignTeamController.TeamController.GetTeams("SELECT * FROM teams WHERE cod = '" + teamTb.Text + "'")[0];
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = assignTeamController.Insert();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                AssignEmployeeView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void ByEmployeeBt_Click(object sender, EventArgs e)
        {
            List<Project> list = new List<Project>();
            list = assignTeamController.ProjectController.GetProjects("SELECT * FROM proyects WHERE cod ='" + projectTb.Text + "'");
            projectsGrid.DataSource = list;
            assignTeamController.ProjectController.Project = list[0];
            MapperFromData();
        }

        private void ByTeamBt_Click(object sender, EventArgs e)
        {
            List<Team> list = new List<Team>();
            list = assignTeamController.TeamController.GetTeams("SELECT * FROM teams WHERE cod ='" + teamTb.Text + "'");
            teamGrid.DataSource = list;
            assignTeamController.TeamController.Team = list[0];
            MapperFromData();
        }

        private void allBt_Click(object sender, EventArgs e)
        {
            AssignEmployeeView_Load(sender, e);
        }

        private void AssignGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = assignGrid.Rows[e.RowIndex];
                projectTb.Text = row.Cells["codproyect"].Value.ToString();
                ByEmployeeBt_Click(sender, e);
                teamTb.Text = row.Cells["codteam"].Value.ToString();
                ByTeamBt_Click(sender, e);
            }
        }

        private void EmployeesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = projectsGrid.Rows[e.RowIndex];
                projectTb.Text = row.Cells["code"].Value.ToString();
                ByEmployeeBt_Click(sender, e);
            }
        }

        private void TeamGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = teamGrid.Rows[e.RowIndex];
                teamTb.Text = row.Cells["code"].Value.ToString();
                ByTeamBt_Click(sender, e);
            }
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = assignTeamController.Delete();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                AssignEmployeeView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }
    }
}
