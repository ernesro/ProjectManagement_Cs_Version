namespace Project_Management._01view
{
    partial class WelcomeWindowView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeWindowView));
            label1 = new Label();
            label2 = new Label();
            tasksBt = new Button();
            teamsBt = new Button();
            projectsBt = new Button();
            employeesBt = new Button();
            commentsBt = new Button();
            assignEmployeeBt = new Button();
            assignTaskBt = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 70.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(252, 15);
            label1.Name = "label1";
            label1.Size = new Size(564, 138);
            label1.TabIndex = 0;
            label1.Text = "PROJECT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 50.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(237, 153);
            label2.Name = "label2";
            label2.Size = new Size(600, 99);
            label2.TabIndex = 1;
            label2.Text = "MANAGEMENT";
            // 
            // tasksBt
            // 
            tasksBt.Location = new Point(878, 354);
            tasksBt.Name = "tasksBt";
            tasksBt.Size = new Size(155, 40);
            tasksBt.TabIndex = 2;
            tasksBt.Text = "Tasks";
            tasksBt.UseVisualStyleBackColor = true;
            tasksBt.Click += tasksBt_Click;
            // 
            // teamsBt
            // 
            teamsBt.Location = new Point(252, 354);
            teamsBt.Name = "teamsBt";
            teamsBt.Size = new Size(155, 40);
            teamsBt.TabIndex = 3;
            teamsBt.Text = "Teams";
            teamsBt.UseVisualStyleBackColor = true;
            teamsBt.Click += teamsBt_Click;
            // 
            // projectsBt
            // 
            projectsBt.Location = new Point(463, 354);
            projectsBt.Name = "projectsBt";
            projectsBt.Size = new Size(155, 40);
            projectsBt.TabIndex = 4;
            projectsBt.Text = "Projects";
            projectsBt.UseVisualStyleBackColor = true;
            projectsBt.Click += projectsBt_Click;
            // 
            // employeesBt
            // 
            employeesBt.Location = new Point(30, 354);
            employeesBt.Name = "employeesBt";
            employeesBt.Size = new Size(155, 40);
            employeesBt.TabIndex = 5;
            employeesBt.Text = "Employees";
            employeesBt.UseVisualStyleBackColor = true;
            employeesBt.Click += employeesBt_Click;
            // 
            // commentsBt
            // 
            commentsBt.Location = new Point(670, 354);
            commentsBt.Name = "commentsBt";
            commentsBt.Size = new Size(155, 40);
            commentsBt.TabIndex = 6;
            commentsBt.Text = "Comments";
            commentsBt.UseVisualStyleBackColor = true;
            commentsBt.Click += commentsBt_Click;
            // 
            // assignEmployeeBt
            // 
            assignEmployeeBt.Location = new Point(30, 486);
            assignEmployeeBt.Name = "assignEmployeeBt";
            assignEmployeeBt.Size = new Size(283, 40);
            assignEmployeeBt.TabIndex = 7;
            assignEmployeeBt.Text = "Assign an Employee to a Team";
            assignEmployeeBt.UseVisualStyleBackColor = true;
            assignEmployeeBt.Click += assignEmployeeBt_Click;
            // 
            // assignTaskBt
            // 
            assignTaskBt.Location = new Point(389, 486);
            assignTaskBt.Name = "assignTaskBt";
            assignTaskBt.Size = new Size(286, 40);
            assignTaskBt.TabIndex = 8;
            assignTaskBt.Text = "Assign a task to an Employee";
            assignTaskBt.UseVisualStyleBackColor = true;
            assignTaskBt.Click += assignTaskBt_Click;
            // 
            // button8
            // 
            button8.Location = new Point(755, 486);
            button8.Name = "button8";
            button8.Size = new Size(278, 40);
            button8.TabIndex = 9;
            button8.Text = "Assign a Project to a Team";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // WelcomeWindowView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 573);
            Controls.Add(button8);
            Controls.Add(assignTaskBt);
            Controls.Add(assignEmployeeBt);
            Controls.Add(commentsBt);
            Controls.Add(employeesBt);
            Controls.Add(projectsBt);
            Controls.Add(teamsBt);
            Controls.Add(tasksBt);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeWindowView";
            Text = "Projest Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button tasksBt;
        private Button teamsBt;
        private Button projectsBt;
        private Button employeesBt;
        private Button commentsBt;
        private Button assignEmployeeBt;
        private Button assignTaskBt;
        private Button button8;
    }
}