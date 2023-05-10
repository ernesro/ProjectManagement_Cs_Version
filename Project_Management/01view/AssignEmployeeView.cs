using MySqlX.XDevAPI.Relational;
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
    public partial class AssignEmployeeView : Form
    {
        private string admin;
        private readonly AssignEmployeeController assignEmployeeController = new();
        public AssignEmployeeView(string admin)
        {
            InitializeComponent();
            this.admin = admin;
            EnableButtons();
            employeesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            assignGrid.DataSource = assignEmployeeController.GetAssignedEmployees("SELECT * FROM assignemployee");
            employeesGrid.DataSource = assignEmployeeController.GetEmployees("SELECT * FROM employees");
            teamGrid.DataSource = assignEmployeeController.GetTeams("SELECT * FROM teams");
            assignEmployeeController.EmployeeController.employee = assignEmployeeController.EmployeeController.GetEmployees("SELECT * FROM employees")[0];
            assignEmployeeController.TeamController.Team = assignEmployeeController.TeamController.GetTeams("SELECT * FROM teams")[0];

            employeesGrid.Columns[4].Visible = false;
            employeesGrid.Columns[5].Visible = false;
            employeesGrid.Columns[6].Visible = false;
            employeesGrid.Columns[7].Visible = false;
            employeesGrid.Columns[8].Visible = false;
            MapperFromData();
        }

        private void MapperFromData()
        {
            employeeTb.Text = assignEmployeeController.EmployeeController.employee.Cod.ToString();
            teamTb.Text = assignEmployeeController.TeamController.Team.Code.ToString();
        }
        private void MapperToData()
        {
            assignEmployeeController.EmployeeController.employee = assignEmployeeController.EmployeeController.GetEmployees("SELECT * FROM employees WHERE cod = '" + employeeTb.Text + "'")[0];
            assignEmployeeController.TeamController.Team = assignEmployeeController.TeamController.GetTeams("SELECT * FROM teams WHERE cod = '" + teamTb.Text + "'")[0];
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = assignEmployeeController.Insert();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                AssignEmployeeView_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void byEmployeeBt_Click(object sender, EventArgs e)
        {
            List<Employee> list = new List<Employee>();
            list = assignEmployeeController.EmployeeController.GetEmployees("SELECT * FROM employees WHERE cod ='" + employeeTb.Text + "'");
            employeesGrid.DataSource = list;
            assignEmployeeController.EmployeeController.employee = list[0];
            MapperFromData();
        }

        private void byTeamBt_Click(object sender, EventArgs e)
        {
            List<Team> list = new List<Team>();
            list = assignEmployeeController.TeamController.GetTeams("SELECT * FROM teams WHERE cod ='" + teamTb.Text + "'");
            teamGrid.DataSource = list;
            assignEmployeeController.TeamController.Team = list[0];
            MapperFromData();
        }

        private void allBt_Click(object sender, EventArgs e)
        {
            AssignEmployeeView_Load(sender, e);
        }

        private void assignGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = assignGrid.Rows[e.RowIndex];
                employeeTb.Text = row.Cells["employeecod"].Value.ToString();
                byEmployeeBt_Click(sender, e);
                teamTb.Text = row.Cells["taskcod"].Value.ToString();
                byTeamBt_Click(sender, e);
            }
        }

        private void employeesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = assignGrid.Rows[e.RowIndex];
                employeeTb.Text = row.Cells["employeecod"].Value.ToString();
                byEmployeeBt_Click(sender, e);
            }
        }

        private void teamGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = assignGrid.Rows[e.RowIndex];
                teamTb.Text = row.Cells["taskcod"].Value.ToString();
                byTeamBt_Click(sender, e);
            }
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = assignEmployeeController.Delete();
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
