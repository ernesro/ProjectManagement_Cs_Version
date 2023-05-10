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
    public partial class WelcomeWindowView : Form
    {
        string admin;
        public WelcomeWindowView(string admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void employeesBt_Click(object sender, EventArgs e)
        {
            Hide();
            new EmployeeView(admin).ShowDialog();
            Show();
        }

        private void teamsBt_Click(object sender, EventArgs e)
        {
            Hide();
            new TeamsView(admin).ShowDialog();
            Show();
        }

        private void projectsBt_Click(object sender, EventArgs e)
        {
            Hide();
            new ProjectView(admin).ShowDialog();
            Show();
        }

        private void commentsBt_Click(object sender, EventArgs e)
        {
            Hide();
            new CommentView(admin).ShowDialog();
            Show();
        }

        private void tasksBt_Click(object sender, EventArgs e)
        {
            Hide();
            new TaskView(admin).ShowDialog();
            Show();
        }

        private void assignEmployeeBt_Click(object sender, EventArgs e)
        {

        }

        private void assignTaskBt_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        
    }
}
