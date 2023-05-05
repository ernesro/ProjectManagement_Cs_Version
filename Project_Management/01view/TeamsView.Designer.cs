namespace Project_Management._01view
{
    partial class TeamsView
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
            codTb = new TextBox();
            nameTb = new TextBox();
            addBt = new Button();
            deleteBt = new Button();
            updateBt = new Button();
            searchBtCodeBt = new Button();
            showAllBt = new Button();
            searchByName = new Button();
            codeLb = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 50);
            label1.TabIndex = 0;
            label1.Text = "Teams";
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Code:";
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
            // codTb
            // 
            codTb.Location = new Point(89, 671);
            codTb.Name = "codTb";
            codTb.Size = new Size(63, 27);
            codTb.TabIndex = 8;
            // 
            // nameTb
            // 
            nameTb.Location = new Point(153, 131);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(341, 27);
            nameTb.TabIndex = 9;
            // 
            // addBt
            // 
            addBt.Location = new Point(12, 510);
            addBt.Name = "addBt";
            addBt.Size = new Size(140, 29);
            addBt.TabIndex = 15;
            addBt.Text = "Add Team";
            addBt.UseVisualStyleBackColor = true;
            addBt.Click += AddBt_Click;
            // 
            // deleteBt
            // 
            deleteBt.Location = new Point(354, 510);
            deleteBt.Name = "deleteBt";
            deleteBt.Size = new Size(140, 29);
            deleteBt.TabIndex = 16;
            deleteBt.Text = "Delete Team";
            deleteBt.UseVisualStyleBackColor = true;
            deleteBt.Click += DeleteBt_Click;
            // 
            // updateBt
            // 
            updateBt.Location = new Point(185, 510);
            updateBt.Name = "updateBt";
            updateBt.Size = new Size(140, 29);
            updateBt.TabIndex = 17;
            updateBt.Text = "Update Team";
            updateBt.UseVisualStyleBackColor = true;
            updateBt.Click += UpdateBt_Click;
            // 
            // searchBtCodeBt
            // 
            searchBtCodeBt.Location = new Point(12, 612);
            searchBtCodeBt.Name = "searchBtCodeBt";
            searchBtCodeBt.Size = new Size(140, 29);
            searchBtCodeBt.TabIndex = 18;
            searchBtCodeBt.Text = "Search By Code";
            searchBtCodeBt.UseVisualStyleBackColor = true;
            searchBtCodeBt.Click += SearchBtDniBt_Click;
            // 
            // showAllBt
            // 
            showAllBt.Location = new Point(354, 612);
            showAllBt.Name = "showAllBt";
            showAllBt.Size = new Size(140, 29);
            showAllBt.TabIndex = 19;
            showAllBt.Text = "Show All";
            showAllBt.UseVisualStyleBackColor = true;
            showAllBt.Click += ShowAllBt_Click;
            // 
            // searchByName
            // 
            searchByName.Location = new Point(183, 612);
            searchByName.Name = "searchByName";
            searchByName.Size = new Size(140, 29);
            searchByName.TabIndex = 20;
            searchByName.Text = "Search By Name";
            searchByName.UseVisualStyleBackColor = true;
            searchByName.Click += SearchByName_Click;
            // 
            // codeLb
            // 
            codeLb.AutoSize = true;
            codeLb.Location = new Point(153, 82);
            codeLb.Name = "codeLb";
            codeLb.Size = new Size(0, 20);
            codeLb.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 674);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 22;
            label9.Text = "Code:";
            // 
            // TeamsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 735);
            Controls.Add(label9);
            Controls.Add(codeLb);
            Controls.Add(searchByName);
            Controls.Add(showAllBt);
            Controls.Add(searchBtCodeBt);
            Controls.Add(updateBt);
            Controls.Add(deleteBt);
            Controls.Add(addBt);
            Controls.Add(nameTb);
            Controls.Add(codTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "TeamsView";
            Text = "EmployeeView";
            Load += Teams_Load;
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
        private TextBox codTb;
        private TextBox nameTb;
        private TextBox lNameTb;
        private TextBox adressTb;
        private TextBox emailTb;
        private Button adminBt;
        private Button UserBt;
        private Button addBt;
        private Button deleteBt;
        private Button updateBt;
        private Button searchBtCodeBt;
        private Button showAllBt;
        private Button searchByName;
        private TextBox phoneTb;
        private Label label8;
        private Label adminLb;
        private Label codeLb;
        private Label label9;
    }
}