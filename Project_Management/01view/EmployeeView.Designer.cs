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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
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
            dataGridView1.Size = new Size(951, 714);
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
            // button1
            // 
            button1.Location = new Point(185, 440);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 13;
            button1.Text = "Make Admin";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(356, 440);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 14;
            button2.Text = "Make User";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 510);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 15;
            button3.Text = "Add User";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(354, 510);
            button4.Name = "button4";
            button4.Size = new Size(140, 29);
            button4.TabIndex = 16;
            button4.Text = "Delete User";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(185, 510);
            button5.Name = "button5";
            button5.Size = new Size(140, 29);
            button5.TabIndex = 17;
            button5.Text = "Update User";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 612);
            button6.Name = "button6";
            button6.Size = new Size(140, 29);
            button6.TabIndex = 18;
            button6.Text = "Search By Dni";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(354, 612);
            button7.Name = "button7";
            button7.Size = new Size(140, 29);
            button7.TabIndex = 19;
            button7.Text = "Show All";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(183, 612);
            button8.Name = "button8";
            button8.Size = new Size(140, 29);
            button8.TabIndex = 20;
            button8.Text = "Search By Name";
            button8.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(1481, 735);
            Controls.Add(adminLb);
            Controls.Add(phoneTb);
            Controls.Add(label8);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox phoneTb;
        private Label label8;
        private Label adminLb;
    }
}