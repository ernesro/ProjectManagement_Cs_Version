namespace Project_Management._01view
{
    partial class UserWindowView
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
            loginBt = new Button();
            passwdTb = new TextBox();
            emailTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            errorLb = new Label();
            error2Lb = new Label();
            SuspendLayout();
            // 
            // loginBt
            // 
            loginBt.Location = new Point(66, 365);
            loginBt.Name = "loginBt";
            loginBt.Size = new Size(334, 37);
            loginBt.TabIndex = 0;
            loginBt.Text = "Login";
            loginBt.UseVisualStyleBackColor = true;
            loginBt.Click += LoginBt_Click;
            // 
            // passwdTb
            // 
            passwdTb.Location = new Point(66, 235);
            passwdTb.Name = "passwdTb";
            passwdTb.Size = new Size(334, 27);
            passwdTb.TabIndex = 1;
            // 
            // emailTb
            // 
            emailTb.Location = new Point(66, 117);
            emailTb.Name = "emailTb";
            emailTb.Size = new Size(334, 27);
            emailTb.TabIndex = 2;
            emailTb.TextChanged += EmailValidating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 77);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 3;
            label1.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 200);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // errorLb
            // 
            errorLb.AutoSize = true;
            errorLb.BackColor = Color.Transparent;
            errorLb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorLb.ForeColor = Color.Red;
            errorLb.Location = new Point(167, 405);
            errorLb.Name = "errorLb";
            errorLb.Size = new Size(125, 23);
            errorLb.TabIndex = 5;
            errorLb.Text = "Email is invalid.";
            // 
            // error2Lb
            // 
            error2Lb.AutoSize = true;
            error2Lb.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            error2Lb.ForeColor = Color.Red;
            error2Lb.Location = new Point(118, 428);
            error2Lb.Name = "error2Lb";
            error2Lb.Size = new Size(234, 23);
            error2Lb.TabIndex = 6;
            error2Lb.Text = "Email or Password are invalid.";
            // 
            // UserWindowView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 472);
            Controls.Add(error2Lb);
            Controls.Add(errorLb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailTb);
            Controls.Add(passwdTb);
            Controls.Add(loginBt);
            Name = "UserWindowView";
            Text = "UserWindowView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBt;
        private TextBox passwdTb;
        private TextBox emailTb;
        private Label label1;
        private Label label2;
        private Label errorLb;
        private Label error2Lb;
    }
}