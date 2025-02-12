namespace AviaSales.Forms
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.linkLabel_notHaveAcc = new System.Windows.Forms.LinkLabel();
            this.btn_visiblePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(122, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Aviasales App!\r\n";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(24, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(24, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(157, 220);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(314, 39);
            this.tb_password.TabIndex = 3;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_login
            // 
            this.tb_login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(157, 144);
            this.tb_login.Multiline = true;
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(314, 43);
            this.tb_login.TabIndex = 4;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LogIn.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_LogIn.Location = new System.Drawing.Point(334, 320);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(147, 44);
            this.btn_LogIn.TabIndex = 5;
            this.btn_LogIn.Text = "Log in";
            this.btn_LogIn.UseVisualStyleBackColor = false;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // linkLabel_notHaveAcc
            // 
            this.linkLabel_notHaveAcc.AutoSize = true;
            this.linkLabel_notHaveAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_notHaveAcc.LinkColor = System.Drawing.Color.DarkGoldenrod;
            this.linkLabel_notHaveAcc.Location = new System.Drawing.Point(25, 342);
            this.linkLabel_notHaveAcc.Name = "linkLabel_notHaveAcc";
            this.linkLabel_notHaveAcc.Size = new System.Drawing.Size(237, 22);
            this.linkLabel_notHaveAcc.TabIndex = 6;
            this.linkLabel_notHaveAcc.TabStop = true;
            this.linkLabel_notHaveAcc.Text = "Don`t have accont? Sign up!";
            this.linkLabel_notHaveAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_notHaveAcc_LinkClicked);
            // 
            // btn_visiblePassword
            // 
            this.btn_visiblePassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_visiblePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_visiblePassword.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_visiblePassword.Image = global::AviaSales.Properties.Resources.visible1;
            this.btn_visiblePassword.Location = new System.Drawing.Point(487, 220);
            this.btn_visiblePassword.Name = "btn_visiblePassword";
            this.btn_visiblePassword.Size = new System.Drawing.Size(52, 39);
            this.btn_visiblePassword.TabIndex = 7;
            this.btn_visiblePassword.UseVisualStyleBackColor = false;
            this.btn_visiblePassword.Click += new System.EventHandler(this.btn_visiblePassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 423);
            this.Controls.Add(this.btn_visiblePassword);
            this.Controls.Add(this.linkLabel_notHaveAcc);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.LinkLabel linkLabel_notHaveAcc;
        private System.Windows.Forms.Button btn_visiblePassword;
    }
}