﻿using Project_Management._02aplication;
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
    public partial class TeamsView : Form
    {
        private readonly string admin;
        private readonly TeamsController teamsController = new();
        public TeamsView(string admin)
        {
            this.admin = admin;
            InitializeComponent();
            WindowStyler.ApplyCustomStyle(this);
            EnableButtons();
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teamsController.GetTeams("SELECT * FROM teams");
            teamsController.Team = teamsController.GetTeams("SELECT * FROM teams")[0];
            MapperFromData();
        }

        public void MapperFromData()
        {
            codeLb.Text = teamsController.Team.Code.ToString();
            nameTb.Text = teamsController.Team.Name;
        }
        public void MapperToData()
        {
            teamsController.Team.Name = nameTb.Text;
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = teamsController.Insert();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                Teams_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void UpdateBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = teamsController.Update();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                Teams_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            MapperToData();
            int ok = teamsController.Delete();
            if (ok > 0)
            {
                Alert.SuccesAlert();
                Teams_Load(sender, e);
            }
            else
                Alert.ErrorAlert();
        }

        private void SearchBtDniBt_Click(object sender, EventArgs e)
        {
            List<Team> teams = teamsController.GetTeams("SELECT * FROM teams WHERE cod = '" + codTb.Text + "'");
            if (teams.Count > 0)
            {
                dataGridView1.DataSource = teams;
                teamsController.Team = teams[0];
                MapperFromData();
            }
        }

        private void ShowAllBt_Click(object sender, EventArgs e) { Teams_Load(sender, e); }

        private void SearchByName_Click(object sender, EventArgs e)
        {
            List<Team> teams = teamsController.GetTeams("SELECT * FROM teams WHERE name = '" + nameTb.Text + "'");
            if (teams.Count > 0)
            {
                dataGridView1.DataSource = teams;
                teamsController.Team = teams[0];
                MapperFromData();
            }
        }

        private void EnableButtons()
        {
            if (admin == "false")
            {
                addBt.Enabled = false;
                updateBt.Enabled = false;
                deleteBt.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                teamsController.Team = new Team(
                                       Convert.ToInt32(row.Cells["Code"].Value),
                                      row.Cells["name"].Value.ToString()
                                      );
                MapperFromData();
            }
        }
    }
}
