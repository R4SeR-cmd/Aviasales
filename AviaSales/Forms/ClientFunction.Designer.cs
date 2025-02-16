namespace AviaSales.Forms
{
    partial class ClientFunction
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
            this.btn_CancelTicket = new FontAwesome.Sharp.IconButton();
            this.btn_TopUpBalance = new FontAwesome.Sharp.IconButton();
            this.btn_YourTickets = new FontAwesome.Sharp.IconButton();
            this.btn_BuyTicket = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lb_TitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChiidForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lb_forTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.btn_CancelTicket);
            this.panelMenu.Controls.Add(this.btn_TopUpBalance);
            this.panelMenu.Controls.Add(this.btn_YourTickets);
            this.panelMenu.Controls.Add(this.btn_BuyTicket);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 623);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_CancelTicket
            // 
            this.btn_CancelTicket.BackColor = System.Drawing.Color.Gray;
            this.btn_CancelTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CancelTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CancelTicket.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btn_CancelTicket.IconColor = System.Drawing.Color.Black;
            this.btn_CancelTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CancelTicket.IconSize = 32;
            this.btn_CancelTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelTicket.Location = new System.Drawing.Point(0, 320);
            this.btn_CancelTicket.Name = "btn_CancelTicket";
            this.btn_CancelTicket.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_CancelTicket.Size = new System.Drawing.Size(220, 60);
            this.btn_CancelTicket.TabIndex = 5;
            this.btn_CancelTicket.Text = "Cancel ticket";
            this.btn_CancelTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CancelTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelTicket.UseVisualStyleBackColor = false;
            this.btn_CancelTicket.Click += new System.EventHandler(this.btn_CancelTicket_Click);
            // 
            // btn_TopUpBalance
            // 
            this.btn_TopUpBalance.BackColor = System.Drawing.Color.Gray;
            this.btn_TopUpBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TopUpBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TopUpBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_TopUpBalance.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btn_TopUpBalance.IconColor = System.Drawing.Color.Black;
            this.btn_TopUpBalance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_TopUpBalance.IconSize = 32;
            this.btn_TopUpBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TopUpBalance.Location = new System.Drawing.Point(0, 260);
            this.btn_TopUpBalance.Name = "btn_TopUpBalance";
            this.btn_TopUpBalance.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_TopUpBalance.Size = new System.Drawing.Size(220, 60);
            this.btn_TopUpBalance.TabIndex = 4;
            this.btn_TopUpBalance.Text = "Top up balance";
            this.btn_TopUpBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TopUpBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TopUpBalance.UseVisualStyleBackColor = false;
            this.btn_TopUpBalance.Click += new System.EventHandler(this.btn_TopUpBalance_Click);
            // 
            // btn_YourTickets
            // 
            this.btn_YourTickets.BackColor = System.Drawing.Color.Gray;
            this.btn_YourTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_YourTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_YourTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_YourTickets.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.btn_YourTickets.IconColor = System.Drawing.Color.Black;
            this.btn_YourTickets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_YourTickets.IconSize = 32;
            this.btn_YourTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_YourTickets.Location = new System.Drawing.Point(0, 200);
            this.btn_YourTickets.Name = "btn_YourTickets";
            this.btn_YourTickets.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_YourTickets.Size = new System.Drawing.Size(220, 60);
            this.btn_YourTickets.TabIndex = 3;
            this.btn_YourTickets.Text = "Your tickets";
            this.btn_YourTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_YourTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_YourTickets.UseVisualStyleBackColor = false;
            this.btn_YourTickets.Click += new System.EventHandler(this.btn_YourTickets_Click);
            // 
            // btn_BuyTicket
            // 
            this.btn_BuyTicket.BackColor = System.Drawing.Color.Gray;
            this.btn_BuyTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_BuyTicket.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_BuyTicket.IconColor = System.Drawing.Color.Black;
            this.btn_BuyTicket.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BuyTicket.IconSize = 32;
            this.btn_BuyTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuyTicket.Location = new System.Drawing.Point(0, 140);
            this.btn_BuyTicket.Name = "btn_BuyTicket";
            this.btn_BuyTicket.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_BuyTicket.Size = new System.Drawing.Size(220, 60);
            this.btn_BuyTicket.TabIndex = 2;
            this.btn_BuyTicket.Text = "Buy ticket";
            this.btn_BuyTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuyTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BuyTicket.UseVisualStyleBackColor = false;
            this.btn_BuyTicket.Click += new System.EventHandler(this.btn_BuyTicket_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Gray;
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
            this.panelTitleBar.BackColor = System.Drawing.Color.Gray;
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
            this.iconCurrentChiidForm.BackColor = System.Drawing.Color.Gray;
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
            this.panelShadow.BackColor = System.Drawing.Color.Gray;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 70);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(899, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Gray;
            this.panelDesktop.Controls.Add(this.lb_forTimer);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(899, 544);
            this.panelDesktop.TabIndex = 3;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AviaSales.Properties.Resources.as_logo_design_template_5ad0717a13ccde12ae6103b709e00f06_screen1;
            this.pictureBox1.Location = new System.Drawing.Point(339, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 199);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 623);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "ClientFunction";
            this.Text = "Client Panel";
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
        private FontAwesome.Sharp.IconButton btn_BuyTicket;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btn_CancelTicket;
        private FontAwesome.Sharp.IconButton btn_TopUpBalance;
        private FontAwesome.Sharp.IconButton btn_YourTickets;
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