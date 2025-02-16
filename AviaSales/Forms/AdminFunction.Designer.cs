namespace AviaSales.Forms
{
    partial class AdminFunction
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_CancelFlight = new FontAwesome.Sharp.IconButton();
            this.btn_EndedFlight = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btn_EditFlight = new FontAwesome.Sharp.IconButton();
            this.btn_CancelTickets = new FontAwesome.Sharp.IconButton();
            this.btn_AddFlight = new FontAwesome.Sharp.IconButton();
            this.btn_AddPlane = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lb_TitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChiidForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_forTimer = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChiidForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btn_CancelFlight);
            this.panelMenu.Controls.Add(this.btn_EndedFlight);
            this.panelMenu.Controls.Add(this.iconButton5);
            this.panelMenu.Controls.Add(this.btn_EditFlight);
            this.panelMenu.Controls.Add(this.btn_CancelTickets);
            this.panelMenu.Controls.Add(this.btn_AddFlight);
            this.panelMenu.Controls.Add(this.btn_AddPlane);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 623);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_CancelFlight
            // 
            this.btn_CancelFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CancelFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CancelFlight.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btn_CancelFlight.IconColor = System.Drawing.Color.Black;
            this.btn_CancelFlight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CancelFlight.IconSize = 32;
            this.btn_CancelFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelFlight.Location = new System.Drawing.Point(0, 500);
            this.btn_CancelFlight.Name = "btn_CancelFlight";
            this.btn_CancelFlight.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_CancelFlight.Size = new System.Drawing.Size(220, 60);
            this.btn_CancelFlight.TabIndex = 8;
            this.btn_CancelFlight.Text = "Cancel flight";
            this.btn_CancelFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelFlight.UseVisualStyleBackColor = true;
            this.btn_CancelFlight.Click += new System.EventHandler(this.btn_CancelFlight_Click);
            // 
            // btn_EndedFlight
            // 
            this.btn_EndedFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EndedFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EndedFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EndedFlight.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_EndedFlight.IconColor = System.Drawing.Color.Black;
            this.btn_EndedFlight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EndedFlight.IconSize = 32;
            this.btn_EndedFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EndedFlight.Location = new System.Drawing.Point(0, 440);
            this.btn_EndedFlight.Name = "btn_EndedFlight";
            this.btn_EndedFlight.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_EndedFlight.Size = new System.Drawing.Size(220, 60);
            this.btn_EndedFlight.TabIndex = 7;
            this.btn_EndedFlight.Text = "Ended flight";
            this.btn_EndedFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EndedFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EndedFlight.UseVisualStyleBackColor = true;
            this.btn_EndedFlight.Click += new System.EventHandler(this.btn_EndedFlight_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 32;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 380);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Size = new System.Drawing.Size(220, 60);
            this.iconButton5.TabIndex = 6;
            this.iconButton5.Text = "Edit flight";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.EditFlight_Click);
            // 
            // btn_EditFlight
            // 
            this.btn_EditFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_EditFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditFlight.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btn_EditFlight.IconColor = System.Drawing.Color.Black;
            this.btn_EditFlight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_EditFlight.IconSize = 32;
            this.btn_EditFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditFlight.Location = new System.Drawing.Point(0, 320);
            this.btn_EditFlight.Name = "btn_EditFlight";
            this.btn_EditFlight.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_EditFlight.Size = new System.Drawing.Size(220, 60);
            this.btn_EditFlight.TabIndex = 5;
            this.btn_EditFlight.Text = "Add account";
            this.btn_EditFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditFlight.UseVisualStyleBackColor = true;
            this.btn_EditFlight.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // btn_CancelTickets
            // 
            this.btn_CancelTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CancelTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CancelTickets.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.btn_CancelTickets.IconColor = System.Drawing.Color.Black;
            this.btn_CancelTickets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CancelTickets.IconSize = 32;
            this.btn_CancelTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelTickets.Location = new System.Drawing.Point(0, 260);
            this.btn_CancelTickets.Name = "btn_CancelTickets";
            this.btn_CancelTickets.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_CancelTickets.Size = new System.Drawing.Size(220, 60);
            this.btn_CancelTickets.TabIndex = 4;
            this.btn_CancelTickets.Text = "Cancel tickets";
            this.btn_CancelTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelTickets.UseVisualStyleBackColor = true;
            this.btn_CancelTickets.Click += new System.EventHandler(this.btn_CancelTickets_Click);
            // 
            // btn_AddFlight
            // 
            this.btn_AddFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddFlight.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_AddFlight.IconColor = System.Drawing.Color.Black;
            this.btn_AddFlight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddFlight.IconSize = 32;
            this.btn_AddFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddFlight.Location = new System.Drawing.Point(0, 200);
            this.btn_AddFlight.Name = "btn_AddFlight";
            this.btn_AddFlight.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_AddFlight.Size = new System.Drawing.Size(220, 60);
            this.btn_AddFlight.TabIndex = 3;
            this.btn_AddFlight.Text = " Add flight";
            this.btn_AddFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddFlight.UseVisualStyleBackColor = true;
            this.btn_AddFlight.Click += new System.EventHandler(this.btn_AddFlight_Click);
            // 
            // btn_AddPlane
            // 
            this.btn_AddPlane.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddPlane.IconChar = FontAwesome.Sharp.IconChar.Plane;
            this.btn_AddPlane.IconColor = System.Drawing.Color.Black;
            this.btn_AddPlane.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddPlane.IconSize = 32;
            this.btn_AddPlane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddPlane.Location = new System.Drawing.Point(0, 140);
            this.btn_AddPlane.Name = "btn_AddPlane";
            this.btn_AddPlane.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_AddPlane.Size = new System.Drawing.Size(220, 60);
            this.btn_AddPlane.TabIndex = 2;
            this.btn_AddPlane.Text = "Add plane";
            this.btn_AddPlane.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddPlane.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddPlane.UseVisualStyleBackColor = true;
            this.btn_AddPlane.Click += new System.EventHandler(this.btn_AddPlane_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btn_Home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // btn_Home
            // 
            this.btn_Home.Image = global::AviaSales.Properties.Resources.as_logo_design_template_5ad0717a13ccde12ae6103b709e00f06_screen11;
            this.btn_Home.Location = new System.Drawing.Point(55, 21);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(99, 95);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.TabStop = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelTitleBar.Controls.Add(this.lb_TitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChiidForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(899, 70);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lb_TitleChildForm
            // 
            this.lb_TitleChildForm.AutoSize = true;
            this.lb_TitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_TitleChildForm.Location = new System.Drawing.Point(69, 28);
            this.lb_TitleChildForm.Name = "lb_TitleChildForm";
            this.lb_TitleChildForm.Size = new System.Drawing.Size(64, 25);
            this.lb_TitleChildForm.TabIndex = 1;
            this.lb_TitleChildForm.Text = "Home";
            // 
            // iconCurrentChiidForm
            // 
            this.iconCurrentChiidForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iconCurrentChiidForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChiidForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChiidForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChiidForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChiidForm.Location = new System.Drawing.Point(20, 21);
            this.iconCurrentChiidForm.Name = "iconCurrentChiidForm";
            this.iconCurrentChiidForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChiidForm.TabIndex = 0;
            this.iconCurrentChiidForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 70);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(899, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelDesktop.Controls.Add(this.lb_forTimer);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(899, 544);
            this.panelDesktop.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AviaSales.Properties.Resources.as_logo_design_template_5ad0717a13ccde12ae6103b709e00f06_screen1;
            this.pictureBox1.Location = new System.Drawing.Point(339, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 199);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_forTimer
            // 
            this.lb_forTimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lb_forTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_forTimer.ForeColor = System.Drawing.Color.Red;
            this.lb_forTimer.Location = new System.Drawing.Point(121, 279);
            this.lb_forTimer.Name = "lb_forTimer";
            this.lb_forTimer.Size = new System.Drawing.Size(640, 142);
            this.lb_forTimer.TabIndex = 5;
            this.lb_forTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 623);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminFunction";
            this.Text = "AdminFunction";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Home)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChiidForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_AddPlane;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btn_CancelFlight;
        private FontAwesome.Sharp.IconButton btn_EndedFlight;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton btn_EditFlight;
        private FontAwesome.Sharp.IconButton btn_CancelTickets;
        private FontAwesome.Sharp.IconButton btn_AddFlight;
        private System.Windows.Forms.PictureBox btn_Home;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChiidForm;
        private System.Windows.Forms.Label lb_TitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_forTimer;
    }
}