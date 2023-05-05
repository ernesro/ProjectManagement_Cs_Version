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
    public partial class UserWindowView : Form
    {
        private LoginWindowController loginWindowController;
        private string email;
        private string password;

        public UserWindowView()
        {
            InitializeComponent();
            loginWindowController = new LoginWindowController();
            errorLb.Visible = false;
            error2Lb.Visible = false;
            passwdTb.UseSystemPasswordChar = true;
        }

        public void MapperFromView()
        {
            email = emailTb.Text;
            password = passwdTb.Text;
        }

        private void EmailValidating(object sender, EventArgs e)
        {
            MapperFromView();
            if (!loginWindowController.IsValidEmail(email))
            {
                emailTb.BackColor = Color.Red;
                errorLb.Visible = true;
            }
            else
            {
                emailTb.BackColor = Color.GreenYellow;
                errorLb.Visible = false;
            }
        }

        private void LoginBt_Click(object sender, EventArgs e)
        {
            MapperFromView();
            if (loginWindowController.Login(email, password) == true)
            {
                string admin = loginWindowController.GetByMailAndPasswd(email, password).Admin;
                ClearTb();
                Hide();
                new WelcomeWindowView(admin).ShowDialog();
                Show();
            }
            else { error2Lb.Visible = true; }
        }

        private void ClearTb()
        {
            emailTb.Text = "";
            passwdTb.Text = "";
        }
    }
}
