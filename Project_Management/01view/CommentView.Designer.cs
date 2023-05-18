namespace Project_Management._01view
{
    partial class CommentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentView));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            codTb = new TextBox();
            cod_TaskTb = new TextBox();
            addBt = new Button();
            deleteBt = new Button();
            updateBt = new Button();
            searchBtCodeBt = new Button();
            showAllBt = new Button();
            codeLb = new Label();
            label9 = new Label();
            contentTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(250, 50);
            label1.TabIndex = 0;
            label1.Text = "Comments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 94);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 143);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 3;
            label3.Text = "Task Code:";
            // 
            // codTb
            // 
            codTb.Location = new Point(83, 680);
            codTb.Name = "codTb";
            codTb.Size = new Size(63, 27);
            codTb.TabIndex = 8;
            // 
            // cod_TaskTb
            // 
            cod_TaskTb.Location = new Point(147, 140);
            cod_TaskTb.Name = "cod_TaskTb";
            cod_TaskTb.Size = new Size(341, 27);
            cod_TaskTb.TabIndex = 9;
            // 
            // addBt
            // 
            addBt.Location = new Point(6, 519);
            addBt.Name = "addBt";
            addBt.Size = new Size(140, 29);
            addBt.TabIndex = 15;
            addBt.Text = "Add Comment";
            addBt.UseVisualStyleBackColor = true;
            addBt.Click += AddBt_Click;
            // 
            // deleteBt
            // 
            deleteBt.Location = new Point(348, 519);
            deleteBt.Name = "deleteBt";
            deleteBt.Size = new Size(140, 29);
            deleteBt.TabIndex = 16;
            deleteBt.Text = "Delete Comment";
            deleteBt.UseVisualStyleBackColor = true;
            deleteBt.Click += DeleteBt_Click;
            // 
            // updateBt
            // 
            updateBt.Location = new Point(179, 519);
            updateBt.Name = "updateBt";
            updateBt.Size = new Size(140, 29);
            updateBt.TabIndex = 17;
            updateBt.Text = "Update Comment";
            updateBt.UseVisualStyleBackColor = true;
            updateBt.Click += UpdateBt_Click;
            // 
            // searchBtCodeBt
            // 
            searchBtCodeBt.Location = new Point(6, 621);
            searchBtCodeBt.Name = "searchBtCodeBt";
            searchBtCodeBt.Size = new Size(140, 29);
            searchBtCodeBt.TabIndex = 18;
            searchBtCodeBt.Text = "Search By Code";
            searchBtCodeBt.UseVisualStyleBackColor = true;
            searchBtCodeBt.Click += SearchBt_Click;
            // 
            // showAllBt
            // 
            showAllBt.Location = new Point(348, 621);
            showAllBt.Name = "showAllBt";
            showAllBt.Size = new Size(140, 29);
            showAllBt.TabIndex = 19;
            showAllBt.Text = "Show All";
            showAllBt.UseVisualStyleBackColor = true;
            showAllBt.Click += ShowAllBt_Click;
            // 
            // codeLb
            // 
            codeLb.Location = new Point(0, 0);
            codeLb.Name = "codeLb";
            codeLb.Size = new Size(100, 23);
            codeLb.TabIndex = 0;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 0;
            // 
            // contentTb
            // 
            contentTb.Location = new Point(147, 206);
            contentTb.Multiline = true;
            contentTb.Name = "contentTb";
            contentTb.Size = new Size(341, 129);
            contentTb.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 206);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 25;
            label4.Text = "Content:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 687);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 26;
            label5.Text = "Code:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(537, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1161, 705);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 94);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 28;
            // 
            // CommentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1710, 726);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(contentTb);
            Controls.Add(showAllBt);
            Controls.Add(searchBtCodeBt);
            Controls.Add(updateBt);
            Controls.Add(deleteBt);
            Controls.Add(addBt);
            Controls.Add(cod_TaskTb);
            Controls.Add(codTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CommentView";
            Text = "Comments";
            Load += CommentView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox codTb;
        private TextBox cod_TaskTb;
        private Button addBt;
        private Button deleteBt;
        private Button updateBt;
        private Button searchBtCodeBt;
        private Button showAllBt;
        private Button searchByName;
        private Label codeLb;
        private Label label9;
        private TextBox contentTb;
        private Label label4;
        private Label stateLb;
        private Button progressBt;
        private Button completedBt;
        private Button holdBt;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
    }
}