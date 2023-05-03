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
    public partial class EmployeeView : Form
    {
        private EmployeesController employeesController = new EmployeesController();
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeesController.GetEmployees("SELECT * FROM employees");
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
            employeesController.employee = employeesController.GetEmployees("SELECT * FROM employees")[0];
            MapperFromData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                employeesController.employee = new Employee(
                    Convert.ToInt32(row.Cells["cod"].Value),
                    row.Cells["dni"].Value.ToString(),
                    row.Cells["name"].Value.ToString(),
                    row.Cells["lastName"].Value.ToString(),
                    row.Cells["address"].Value.ToString(),
                    row.Cells["email"].Value.ToString(),
                    row.Cells["phoneNumber"].Value.ToString(),
                    row.Cells["admin"].Value.ToString(),
                    row.Cells["password"].Value.ToString()
                );
                MapperFromData();
            }
        }

        public void MapperFromData()
        {
            dniTb.Text = employeesController.employee.Dni;
            nameTb.Text = employeesController.employee.Name;
            lNameTb.Text = employeesController.employee.LastName;
            adressTb.Text = employeesController.employee.Address;
            emailTb.Text = employeesController.employee.Email;
            phoneTb.Text = employeesController.employee.PhoneNumber;
            adminLb.Text = employeesController.employee.Admin;
        }
    }
}
