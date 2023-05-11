namespace Project_Management._01view
{
    partial class AssignEmployeeView
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
            employeesGrid = new DataGridView();
            teamGrid = new DataGridView();
            assignGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addBt = new Button();
            deleteBt = new Button();
            allBt = new Button();
            byEmployeeBt = new Button();
            byTeamBt = new Button();
            employeeTb = new TextBox();
            teamTb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)employeesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assignGrid).BeginInit();
            SuspendLayout();
            // 
            // employeesGrid
            // 
            employeesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeesGrid.Location = new Point(393, 12);
            employeesGrid.Name = "employeesGrid";
            employeesGrid.RowHeadersWidth = 51;
            employeesGrid.RowTemplate.Height = 29;
            employeesGrid.Size = new Size(467, 695);
            employeesGrid.TabIndex = 0;
            employeesGrid.CellClick += EmployeesGrid_CellClick;
            // 
            // teamGrid
            // 
            teamGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teamGrid.Location = new Point(1278, 12);
            teamGrid.Name = "teamGrid";
            teamGrid.RowHeadersWidth = 51;
            teamGrid.Size = new Size(469, 695);
            teamGrid.TabIndex = 1;
            teamGrid.CellClick += TeamGrid_CellClick;
            // 
            // assignGrid
            // 
            assignGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignGrid.Location = new Point(920, 12);
            assignGrid.Name = "assignGrid";
            assignGrid.RowHeadersWidth = 51;
            assignGrid.Size = new Size(300, 695);
            assignGrid.TabIndex = 2;
            assignGrid.CellClick += AssignGrid_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(326, 40);
            label1.TabIndex = 3;
            label1.Text = "Assign Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 157);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 4;
            label2.Text = "Employee Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 224);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 5;
            label3.Text = "Team Code";
            // 
            // addBt
            // 
            addBt.Location = new Point(12, 328);
            addBt.Name = "addBt";
            addBt.Size = new Size(162, 29);
            addBt.TabIndex = 6;
            addBt.Text = "Add";
            addBt.UseVisualStyleBackColor = true;
            addBt.Click += AddBt_Click;
            // 
            // deleteBt
            // 
            deleteBt.Location = new Point(216, 328);
            deleteBt.Name = "deleteBt";
            deleteBt.Size = new Size(162, 29);
            deleteBt.TabIndex = 7;
            deleteBt.Text = "Delete";
            deleteBt.UseVisualStyleBackColor = true;
            deleteBt.Click += DeleteBt_Click;
            // 
            // allBt
            // 
            allBt.Location = new Point(12, 630);
            allBt.Name = "allBt";
            allBt.Size = new Size(162, 29);
            allBt.TabIndex = 8;
            allBt.Text = "Show All";
            allBt.UseVisualStyleBackColor = true;
            allBt.Click += allBt_Click;
            // 
            // byEmployeeBt
            // 
            byEmployeeBt.Location = new Point(12, 573);
            byEmployeeBt.Name = "byEmployeeBt";
            byEmployeeBt.Size = new Size(162, 29);
            byEmployeeBt.TabIndex = 9;
            byEmployeeBt.Text = "Search by Employee";
            byEmployeeBt.UseVisualStyleBackColor = true;
            byEmployeeBt.Click += ByEmployeeBt_Click;
            // 
            // byTeamBt
            // 
            byTeamBt.Location = new Point(216, 573);
            byTeamBt.Name = "byTeamBt";
            byTeamBt.Size = new Size(162, 29);
            byTeamBt.TabIndex = 10;
            byTeamBt.Text = "Search by Team";
            byTeamBt.UseVisualStyleBackColor = true;
            byTeamBt.Click += ByTeamBt_Click;
            // 
            // employeeTb
            // 
            employeeTb.Location = new Point(143, 154);
            employeeTb.Name = "employeeTb";
            employeeTb.Size = new Size(235, 27);
            employeeTb.TabIndex = 11;
            // 
            // teamTb
            // 
            teamTb.Location = new Point(143, 221);
            teamTb.Name = "teamTb";
            teamTb.Size = new Size(235, 27);
            teamTb.TabIndex = 12;
            // 
            // AssignEmployeeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1759, 719);
            Controls.Add(teamTb);
            Controls.Add(employeeTb);
            Controls.Add(byTeamBt);
            Controls.Add(byEmployeeBt);
            Controls.Add(allBt);
            Controls.Add(deleteBt);
            Controls.Add(addBt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(assignGrid);
            Controls.Add(teamGrid);
            Controls.Add(employeesGrid);
            Name = "AssignEmployeeView";
            Text = "AssignEmployeeView";
            Load += AssignEmployeeView_Load;
            ((System.ComponentModel.ISupportInitialize)employeesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)assignGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView employeesGrid;
        private DataGridView teamGrid;
        private DataGridView assignGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addBt;
        private Button deleteBt;
        private Button allBt;
        private Button byEmployeeBt;
        private Button byTeamBt;
        private TextBox employeeTb;
        private TextBox teamTb;
    }
}