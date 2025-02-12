namespace AviaSales.Forms
{
    partial class ClientProfile
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.lb_cash = new System.Windows.Forms.Label();
            this.lb_balance = new System.Windows.Forms.Label();
            this.lb_age = new System.Windows.Forms.Label();
            this.lb_surname = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(22, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Functional";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.Color.White;
            this.btn_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_setting.Location = new System.Drawing.Point(22, 145);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(157, 41);
            this.btn_setting.TabIndex = 8;
            this.btn_setting.Text = "Settings";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.White;
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_info.Location = new System.Drawing.Point(22, 59);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(157, 42);
            this.btn_info.TabIndex = 7;
            this.btn_info.Text = "Information";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.White;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_logout.Location = new System.Drawing.Point(50, 361);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(129, 42);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.lb_cash);
            this.groupBox1.Controls.Add(this.lb_balance);
            this.groupBox1.Controls.Add(this.lb_age);
            this.groupBox1.Controls.Add(this.lb_surname);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(564, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 228);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client`s data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Surname:";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(6, 48);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(70, 25);
            this.B.TabIndex = 8;
            this.B.Text = "Name:";
            // 
            // lb_cash
            // 
            this.lb_cash.AutoSize = true;
            this.lb_cash.Location = new System.Drawing.Point(101, 179);
            this.lb_cash.Name = "lb_cash";
            this.lb_cash.Size = new System.Drawing.Size(107, 25);
            this.lb_cash.TabIndex = 7;
            this.lb_cash.Text = "lb_balance";
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Location = new System.Drawing.Point(6, 179);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(89, 25);
            this.lb_balance.TabIndex = 6;
            this.lb_balance.Text = "Balance:";
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Location = new System.Drawing.Point(82, 130);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(64, 25);
            this.lb_age.TabIndex = 5;
            this.lb_age.Text = "label4";
            // 
            // lb_surname
            // 
            this.lb_surname.AutoSize = true;
            this.lb_surname.Location = new System.Drawing.Point(101, 89);
            this.lb_surname.Name = "lb_surname";
            this.lb_surname.Size = new System.Drawing.Size(64, 25);
            this.lb_surname.TabIndex = 4;
            this.lb_surname.Text = "label4";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(82, 48);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(64, 25);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AviaSales.Properties.Resources.ProfileImg;
            this.pictureBox1.Location = new System.Drawing.Point(256, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 228);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ClientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1111, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClientProfile";
            this.Text = "Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_cash;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label lb_surname;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label B;
    }
}