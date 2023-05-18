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
    public partial class AssignTaskView : Form
    {

        private string admin;
        private readonly AssignTaskController assignTaskController = new();
        public AssignTaskView(string admin)
        {
            InitializeComponent();
            WindowStyler.ApplyCustomStyle(this);
            this.admin = admin;
            EnableButtons();
            employeesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            assignGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tasksGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            assignGrid.DataSource = assignTaskController.GetAssignedTasks("SELECT * FROM assigntask");
            employeesGrid.DataSource = assignTaskController.GetEmployees("SELECT * FROM employees");
            tasksGrid.DataSource = assignTaskController.GetTasks("SELECT * FROM tasks");
            assignTaskController.EmployeeController.employee = assignTaskController.EmployeeController.GetEmployees("SELECT * FROM employees")[0];
            assignTaskController.TaskController.Task = assignTaskController.TaskController.GetTasks("SELECT * FROM tasks")[0];

            employeesGrid.Columns[4].Visible = false;
            employeesGrid.Columns[5].Visible = false;
            employeesGrid.Columns[6].Visible = false;
            employeesGrid.Columns[7].Visible = false;
            employeesGrid.Columns[8].Visible = false;
            MapperFromData();
        }

        private void MapperFromData()
        {
            employeeTb.Text = assignTaskController.EmployeeController.employee.Cod.ToString();
            taskTb.Text = assignTaskController.TaskController.Task.Code.ToString();
        }
        private void MapperToData()
        {
            assignTaskController.EmployeeController.employee = assignTaskController.EmployeeController.GetEmployees("SELECT * FROM employees WHERE cod = '" + employeeTb.Text + "'")[0];
            assignTaskController.TaskController.Task = assignTaskController.TaskController.GetTasks("SELECT * FROM tasks WHERE cod = '" + taskTb.Text + "'")[0];
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = assignTaskController.Insert();
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
            List<Employee> list = new List<Employee>();
            list = assignTaskController.EmployeeController.GetEmployees("SELECT * FROM employees WHERE cod ='" + employeeTb.Text + "'");
            employeesGrid.DataSource = list;
            assignTaskController.EmployeeController.employee = list[0];
            MapperFromData();
        }

        private void ByTaskBt_Click(object sender, EventArgs e)
        {
            List<Task_> list = new List<Task_>();
            list = assignTaskController.TaskController.GetTasks("SELECT * FROM tasks WHERE cod ='" + taskTb.Text + "'");
            tasksGrid.DataSource = list;
            assignTaskController.TaskController.Task = list[0];
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
                employeeTb.Text = row.Cells["codemployee"].Value.ToString();
                ByEmployeeBt_Click(sender, e);
                taskTb.Text = row.Cells["codtask"].Value.ToString();
                ByTaskBt_Click(sender, e);
            }
        }

        private void EmployeesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = employeesGrid.Rows[e.RowIndex];
                employeeTb.Text = row.Cells["cod"].Value.ToString();
                ByEmployeeBt_Click(sender, e);
            }
        }

        private void TaskGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tasksGrid.Rows[e.RowIndex];
                taskTb.Text = row.Cells["code"].Value.ToString();
                ByTaskBt_Click(sender, e);
            }
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = assignTaskController.Delete();
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
