namespace SmartHomeClientv2
{
    partial class Form1
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogUsername = new System.Windows.Forms.TextBox();
            this.textBoxLogPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(153, 33);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Location = new System.Drawing.Point(389, 33);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(63, 13);
            this.labelRegistration.TabIndex = 1;
            this.labelRegistration.Text = "Registration";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(39, 73);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(39, 120);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxLogUsername
            // 
            this.textBoxLogUsername.Location = new System.Drawing.Point(156, 70);
            this.textBoxLogUsername.Name = "textBoxLogUsername";
            this.textBoxLogUsername.Size = new System.Drawing.Size(162, 20);
            this.textBoxLogUsername.TabIndex = 4;
            // 
            // textBoxLogPassword
            // 
            this.textBoxLogPassword.Location = new System.Drawing.Point(156, 117);
            this.textBoxLogPassword.Name = "textBoxLogPassword";
            this.textBoxLogPassword.PasswordChar = '•';
            this.textBoxLogPassword.Size = new System.Drawing.Size(162, 20);
            this.textBoxLogPassword.TabIndex = 5;
            // 
            // textBoxRegPassword
            // 
            this.textBoxRegPassword.Location = new System.Drawing.Point(392, 117);
            this.textBoxRegPassword.Name = "textBoxRegPassword";
            this.textBoxRegPassword.PasswordChar = '•';
            this.textBoxRegPassword.Size = new System.Drawing.Size(162, 20);
            this.textBoxRegPassword.TabIndex = 7;
            // 
            // textBoxRegUsername
            // 
            this.textBoxRegUsername.Location = new System.Drawing.Point(392, 70);
            this.textBoxRegUsername.Name = "textBoxRegUsername";
            this.textBoxRegUsername.Size = new System.Drawing.Size(162, 20);
            this.textBoxRegUsername.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(156, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(392, 166);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(162, 23);
            this.btnRegistration.TabIndex = 9;
            this.btnRegistration.Text = "REGISTRATION";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 221);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxRegPassword);
            this.Controls.Add(this.textBoxRegUsername);
            this.Controls.Add(this.textBoxLogPassword);
            this.Controls.Add(this.textBoxLogUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelRegistration);
            this.Controls.Add(this.labelLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogUsername;
        private System.Windows.Forms.TextBox textBoxLogPassword;
        private System.Windows.Forms.TextBox textBoxRegPassword;
        private System.Windows.Forms.TextBox textBoxRegUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistration;
    }
}

