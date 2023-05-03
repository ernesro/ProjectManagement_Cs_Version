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
        public WelcomeWindowView()
        {
            InitializeComponent();
        }

        private void employeesBt_Click(object sender, EventArgs e)
        {
            Hide();
            new EmployeeView().ShowDialog();
            Show();
        }

        private void teamsBt_Click(object sender, EventArgs e)
        {

        }

        private void projectsBt_Click(object sender, EventArgs e)
        {

        }

        private void commentsBt_Click(object sender, EventArgs e)
        {

        }

        private void tasksBt_Click(object sender, EventArgs e)
        {

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
