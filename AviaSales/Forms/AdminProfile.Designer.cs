namespace AviaSales.Forms
{
    partial class AdminProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_age = new System.Windows.Forms.Label();
            this.lb_surname = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_functional = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_age);
            this.groupBox1.Controls.Add(this.lb_surname);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(338, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin`s data";
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
            this.lb_surname.Location = new System.Drawing.Point(126, 89);
            this.lb_surname.Name = "lb_surname";
            this.lb_surname.Size = new System.Drawing.Size(64, 25);
            this.lb_surname.TabIndex = 4;
            this.lb_surname.Text = "label4";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(98, 48);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(64, 25);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Location = new System.Drawing.Point(811, 378);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(131, 53);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_info.ForeColor = System.Drawing.Color.Black;
            this.btn_info.Location = new System.Drawing.Point(1, -1);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(101, 28);
            this.btn_info.TabIndex = 2;
            this.btn_info.Text = "Information";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_setting.ForeColor = System.Drawing.Color.Black;
            this.btn_setting.Location = new System.Drawing.Point(119, -1);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(101, 28);
            this.btn_setting.TabIndex = 3;
            this.btn_setting.Text = "Settings";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_functional
            // 
            this.btn_functional.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_functional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_functional.ForeColor = System.Drawing.Color.Black;
            this.btn_functional.Location = new System.Drawing.Point(240, -1);
            this.btn_functional.Name = "btn_functional";
            this.btn_functional.Size = new System.Drawing.Size(101, 28);
            this.btn_functional.TabIndex = 4;
            this.btn_functional.Text = "Functional";
            this.btn_functional.UseVisualStyleBackColor = false;
            this.btn_functional.Click += new System.EventHandler(this.btn_functional_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AviaSales.Properties.Resources.ImgAdmin1;
            this.pictureBox1.Location = new System.Drawing.Point(47, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 231);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_functional);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label lb_surname;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_functional;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}