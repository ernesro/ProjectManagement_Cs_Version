namespace Project_Management._01view
{
    partial class TaskView
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
            titleTb = new TextBox();
            addBt = new Button();
            deleteBt = new Button();
            updateBt = new Button();
            searchBtCodeBt = new Button();
            showAllBt = new Button();
            searchByName = new Button();
            codeLb = new Label();
            label9 = new Label();
            descriptionTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            stateLb = new Label();
            progressBt = new Button();
            completedBt = new Button();
            holdBt = new Button();
            label6 = new Label();
            label7 = new Label();
            projectTb = new TextBox();
            projectLb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 50);
            label1.TabIndex = 0;
            label1.Text = "Tasks";
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
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            label3.Size = new Size(41, 20);
            label3.TabIndex = 3;
            label3.Text = "Title:";
            // 
            // codTb
            // 
            codTb.Location = new Point(104, 671);
            codTb.Name = "codTb";
            codTb.Size = new Size(48, 27);
            codTb.TabIndex = 8;
            // 
            // titleTb
            // 
            titleTb.Location = new Point(153, 131);
            titleTb.Name = "titleTb";
            titleTb.Size = new Size(341, 27);
            titleTb.TabIndex = 9;
            // 
            // addBt
            // 
            addBt.Location = new Point(12, 552);
            addBt.Name = "addBt";
            addBt.Size = new Size(140, 29);
            addBt.TabIndex = 15;
            addBt.Text = "Add Project";
            addBt.UseVisualStyleBackColor = true;
            addBt.Click += AddBt_Click;
            // 
            // deleteBt
            // 
            deleteBt.Location = new Point(354, 552);
            deleteBt.Name = "deleteBt";
            deleteBt.Size = new Size(140, 29);
            deleteBt.TabIndex = 16;
            deleteBt.Text = "Delete Project";
            deleteBt.UseVisualStyleBackColor = true;
            deleteBt.Click += DeleteBt_Click;
            // 
            // updateBt
            // 
            updateBt.Location = new Point(185, 552);
            updateBt.Name = "updateBt";
            updateBt.Size = new Size(140, 29);
            updateBt.TabIndex = 17;
            updateBt.Text = "Update Project";
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
            searchBtCodeBt.Click += SearchBt_Click;
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
            searchByName.Text = "Search By Project";
            searchByName.UseVisualStyleBackColor = true;
            searchByName.Click += searchByName_Click;
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
            // descriptionTb
            // 
            descriptionTb.Location = new Point(153, 197);
            descriptionTb.Multiline = true;
            descriptionTb.Name = "descriptionTb";
            descriptionTb.Size = new Size(341, 129);
            descriptionTb.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 25;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 442);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 26;
            label5.Text = "State:";
            // 
            // stateLb
            // 
            stateLb.AutoSize = true;
            stateLb.Location = new Point(154, 442);
            stateLb.Name = "stateLb";
            stateLb.Size = new Size(0, 20);
            stateLb.TabIndex = 27;
            // 
            // progressBt
            // 
            progressBt.Location = new Point(13, 492);
            progressBt.Name = "progressBt";
            progressBt.Size = new Size(140, 29);
            progressBt.TabIndex = 28;
            progressBt.Text = "Set in progress";
            progressBt.UseVisualStyleBackColor = true;
            progressBt.Click += progressBt_Click;
            // 
            // completedBt
            // 
            completedBt.Location = new Point(354, 492);
            completedBt.Name = "completedBt";
            completedBt.Size = new Size(140, 29);
            completedBt.TabIndex = 29;
            completedBt.Text = "Set completed";
            completedBt.UseVisualStyleBackColor = true;
            completedBt.Click += completedBt_Click;
            // 
            // holdBt
            // 
            holdBt.Location = new Point(185, 492);
            holdBt.Name = "holdBt";
            holdBt.Size = new Size(140, 29);
            holdBt.TabIndex = 30;
            holdBt.Text = "Set not started";
            holdBt.UseVisualStyleBackColor = true;
            holdBt.Click += onHoldBt_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 379);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 31;
            label6.Text = "Project Cod:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 678);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 32;
            label7.Text = "Project Code:";
            // 
            // projectTb
            // 
            projectTb.Location = new Point(449, 671);
            projectTb.Name = "projectTb";
            projectTb.Size = new Size(45, 27);
            projectTb.TabIndex = 33;
            // 
            // projectLb
            // 
            projectLb.Location = new Point(153, 372);
            projectLb.Name = "projectLb";
            projectLb.Size = new Size(341, 27);
            projectLb.TabIndex = 34;
            // 
            // TaskView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 726);
            Controls.Add(projectLb);
            Controls.Add(projectTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(holdBt);
            Controls.Add(completedBt);
            Controls.Add(progressBt);
            Controls.Add(stateLb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(descriptionTb);
            Controls.Add(label9);
            Controls.Add(codeLb);
            Controls.Add(searchByName);
            Controls.Add(showAllBt);
            Controls.Add(searchBtCodeBt);
            Controls.Add(updateBt);
            Controls.Add(deleteBt);
            Controls.Add(addBt);
            Controls.Add(titleTb);
            Controls.Add(codTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "TaskView";
            Text = "TaskView";
            Load += TaskView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox codTb;
        private TextBox titleTb;
        private Button addBt;
        private Button deleteBt;
        private Button updateBt;
        private Button searchBtCodeBt;
        private Button showAllBt;
        private Button searchByName;
        private Label codeLb;
        private Label label9;
        private TextBox descriptionTb;
        private Label label4;
        private Label label5;
        private Label stateLb;
        private Button progressBt;
        private Button completedBt;
        private Button holdBt;
        private Label label6;
        private Label label7;
        private TextBox projectTb;
        private TextBox projectLb;
    }
}
