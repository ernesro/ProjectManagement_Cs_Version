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
    using BaseDatos._03data;
    using Project_Management._02aplication.objects;
    using System.Text.RegularExpressions;

    public partial class EmployeeView : Form
    {
        private readonly string admin;
        private readonly EmployeesController employeesController = new();
        public EmployeeView(string admin)
        {
            WindowStyler.ApplyCustomStyle(this);
            InitializeComponent();
            this.admin = admin;
            EnableButtons();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeesController.GetEmployees("SELECT * FROM employees");
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
            if (admin == "false")
                dataGridView1.Columns[dataGridView1.Columns.Count - 2].Visible = false;
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
        public void MapperToData()
        {
            employeesController.employee.Dni = dniTb.Text;
            employeesController.employee.Name = nameTb.Text;
            employeesController.employee.LastName = lNameTb.Text;
            employeesController.employee.Address = adressTb.Text;
            employeesController.employee.Email = emailTb.Text;
            employeesController.employee.PhoneNumber = phoneTb.Text;
            employeesController.employee.Admin = adminLb.Text;
        }

        private void adminBt_Click(object sender, EventArgs e) { adminLb.Text = "true"; }
        private void UserBt_Click(object sender, EventArgs e) { adminLb.Text = "false"; }

        private void searchBtDniBt_Click(object sender, EventArgs e)
        {
            List<Employee> employees = employeesController.GetEmployees("SELECT * FROM employees WHERE dni = '" + dniTb.Text + "'");
            if (employees.Count > 0)
            {
                dataGridView1.DataSource = employees;
                employeesController.employee = employees[0];
                MapperFromData();
            }
        }

        private void showAllBt_Click(object sender, EventArgs e) { Employees_Load(sender, e); }

        private void searchByName_Click(object sender, EventArgs e)
        {
            List<Employee> employees = employeesController.GetEmployees("SELECT * FROM employees WHERE name = '" + nameTb.Text + "'");
            if (employees.Count > 0)
            {
                dataGridView1.DataSource = employees;
                employeesController.employee = employees[0];
                MapperFromData();
            }
        }

        private void addUserBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = employeesController.InsertEmployee();
            if (ok > 0)
            {
                MessageBox.Show("Se ha insertado correctamente");
                Employees_Load(sender, e);
            }
            else
                Alert.ErrorAlert(employeesController.Error());
        }

        private void updateUserBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = employeesController.UpdateEmployee();
            if (ok > 0)
            {
                MessageBox.Show("Se ha actualizado correctamente");
                Employees_Load(sender, e);
            }
            else
                MessageBox.Show(employeesController.Error());
        }

        private void deleteUserBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = employeesController.DeleteEmployee();
            if (ok > 0)
            {
                MessageBox.Show("Se ha eliminado correctamente");
                Employees_Load(sender, e);
            }
            else
                MessageBox.Show(employeesController.Error());
        }

        public void EnableButtons()
        {
            bool isAdmin;
            if (admin == "false")
                isAdmin = false;
            else
                isAdmin = true;
            addUserBt.Enabled = isAdmin;
            deleteUserBt.Enabled = isAdmin;
            updateUserBt.Enabled = isAdmin;
            adminBt.Enabled = isAdmin;
            UserBt.Enabled = isAdmin;
            adminLb.Visible = isAdmin;

        }

        private bool IsValidDni(string dni)
        {
            // Expresión regular para validar el DNI
            string pattern = @"^\d{8}[A-HJ-NP-TV-Z]$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(dni);
        }

        private bool IsValidEmail(string email)
        {
            // Expresión regular para validar el email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

        private bool IsValidPhone(string phone)
        {
            // Expresión regular para validar el número de teléfono
            string pattern = @"^\d{9}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(phone);
        }

        private void ValidateTextBox(object sender, EventArgs e)
        {
            string dni = dniTb.Text;
            string phone = phoneTb.Text;
            string email = emailTb.Text;
            if (admin == "true")
            {
                if (!IsValidDni(dni) || !IsValidEmail(email) || !IsValidPhone(phone))
                {
                    addUserBt.Enabled = false;
                    updateUserBt.Enabled = false;
                    deleteUserBt.Enabled = false;
                }
                else
                {
                    addUserBt.Enabled = true;
                    updateUserBt.Enabled = true;
                    deleteUserBt.Enabled = true;
                }
            }

            if (!IsValidDni(dni))
                dniTb.BackColor = System.Drawing.Color.Red;
            else
                dniTb.BackColor = System.Drawing.Color.White;

            if (!IsValidEmail(email))
                emailTb.BackColor = System.Drawing.Color.Red;
            else
                emailTb.BackColor = System.Drawing.Color.White;

            if (!IsValidPhone(phone))
                phoneTb.BackColor = System.Drawing.Color.Red;
            else
                phoneTb.BackColor = System.Drawing.Color.White;
        }
    }
}
