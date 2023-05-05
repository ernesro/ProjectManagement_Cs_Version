namespace Project_Management._01view
{
    partial class EmployeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dniTb = new TextBox();
            nameTb = new TextBox();
            lNameTb = new TextBox();
            adressTb = new TextBox();
            emailTb = new TextBox();
            adminBt = new Button();
            UserBt = new Button();
            addUserBt = new Button();
            deleteUserBt = new Button();
            updateUserBt = new Button();
            searchBtDniBt = new Button();
            showAllBt = new Button();
            searchByName = new Button();
            phoneTb = new TextBox();
            label8 = new Label();
            adminLb = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 50);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(518, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1185, 714);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "Dni:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 4;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 239);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 5;
            label5.Text = "Adress:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 348);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 400);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 7;
            label7.Text = "Admin:";
            // 
            // dniTb
            // 
            dniTb.Location = new Point(153, 79);
            dniTb.Name = "dniTb";
            dniTb.Size = new Size(341, 27);
            dniTb.TabIndex = 8;
            // 
            // nameTb
            // 
            nameTb.Location = new Point(153, 131);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(341, 27);
            nameTb.TabIndex = 9;
            // 
            // lNameTb
            // 
            lNameTb.Location = new Point(153, 183);
            lNameTb.Name = "lNameTb";
            lNameTb.Size = new Size(341, 27);
            lNameTb.TabIndex = 10;
            // 
            // adressTb
            // 
            adressTb.Location = new Point(153, 236);
            adressTb.Name = "adressTb";
            adressTb.Size = new Size(341, 27);
            adressTb.TabIndex = 11;
            // 
            // emailTb
            // 
            emailTb.Location = new Point(153, 345);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(341, 27);
            emailTb.TabIndex = 12;
            // 
            // adminBt
            // 
            adminBt.Location = new Point(185, 440);
            adminBt.Name = "adminBt";
            adminBt.Size = new Size(138, 29);
            adminBt.TabIndex = 13;
            adminBt.Text = "Make Admin";
            adminBt.UseVisualStyleBackColor = true;
            adminBt.Click += adminBt_Click;
            // 
            // UserBt
            // 
            UserBt.Location = new Point(356, 440);
            UserBt.Name = "UserBt";
            UserBt.Size = new Size(138, 29);
            UserBt.TabIndex = 14;
            UserBt.Text = "Make User";
            UserBt.UseVisualStyleBackColor = true;
            UserBt.Click += UserBt_Click;
            // 
            // addUserBt
            // 
            addUserBt.Location = new Point(12, 510);
            addUserBt.Name = "addUserBt";
            addUserBt.Size = new Size(140, 29);
            addUserBt.TabIndex = 15;
            addUserBt.Text = "Add User";
            addUserBt.UseVisualStyleBackColor = true;
            addUserBt.Click += addUserBt_Click;
            // 
            // deleteUserBt
            // 
            deleteUserBt.Location = new Point(354, 510);
            deleteUserBt.Name = "deleteUserBt";
            deleteUserBt.Size = new Size(140, 29);
            deleteUserBt.TabIndex = 16;
            deleteUserBt.Text = "Delete User";
            deleteUserBt.UseVisualStyleBackColor = true;
            deleteUserBt.Click += deleteUserBt_Click;
            // 
            // updateUserBt
            // 
            updateUserBt.Location = new Point(185, 510);
            updateUserBt.Name = "updateUserBt";
            updateUserBt.Size = new Size(140, 29);
            updateUserBt.TabIndex = 17;
            updateUserBt.Text = "Update User";
            updateUserBt.UseVisualStyleBackColor = true;
            updateUserBt.Click += updateUserBt_Click;
            // 
            // searchBtDniBt
            // 
            searchBtDniBt.Location = new Point(12, 612);
            searchBtDniBt.Name = "searchBtDniBt";
            searchBtDniBt.Size = new Size(140, 29);
            searchBtDniBt.TabIndex = 18;
            searchBtDniBt.Text = "Search By Dni";
            searchBtDniBt.UseVisualStyleBackColor = true;
            searchBtDniBt.Click += searchBtDniBt_Click;
            // 
            // showAllBt
            // 
            showAllBt.Location = new Point(354, 612);
            showAllBt.Name = "showAllBt";
            showAllBt.Size = new Size(140, 29);
            showAllBt.TabIndex = 19;
            showAllBt.Text = "Show All";
            showAllBt.UseVisualStyleBackColor = true;
            showAllBt.Click += showAllBt_Click;
            // 
            // searchByName
            // 
            searchByName.Location = new Point(183, 612);
            searchByName.Name = "searchByName";
            searchByName.Size = new Size(140, 29);
            searchByName.TabIndex = 20;
            searchByName.Text = "Search By Name";
            searchByName.UseVisualStyleBackColor = true;
            searchByName.Click += searchByName_Click;
            // 
            // phoneTb
            // 
            phoneTb.Location = new Point(153, 291);
            phoneTb.Name = "phoneTb";
            phoneTb.Size = new Size(341, 27);
            phoneTb.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 294);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 21;
            label8.Text = "Phone Number:";
            // 
            // adminLb
            // 
            adminLb.AutoSize = true;
            adminLb.Location = new Point(153, 400);
            adminLb.Name = "adminLb";
            adminLb.Size = new Size(0, 20);
            adminLb.TabIndex = 23;
            // 
            // EmployeeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 735);
            Controls.Add(adminLb);
            Controls.Add(phoneTb);
            Controls.Add(label8);
            Controls.Add(searchByName);
            Controls.Add(showAllBt);
            Controls.Add(searchBtDniBt);
            Controls.Add(updateUserBt);
            Controls.Add(deleteUserBt);
            Controls.Add(addUserBt);
            Controls.Add(UserBt);
            Controls.Add(adminBt);
            Controls.Add(emailTb);
            Controls.Add(adressTb);
            Controls.Add(lNameTb);
            Controls.Add(nameTb);
            Controls.Add(dniTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "EmployeeView";
            Text = "EmployeeView";
            Load += Employees_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox dniTb;
        private TextBox nameTb;
        private TextBox lNameTb;
        private TextBox adressTb;
        private TextBox emailTb;
        private Button adminBt;
        private Button UserBt;
        private Button addUserBt;
        private Button deleteUserBt;
        private Button updateUserBt;
        private Button searchBtDniBt;
        private Button showAllBt;
        private Button searchByName;
        private TextBox phoneTb;
        private Label label8;
        private Label adminLb;
    }
}