namespace AviaSales.Forms
{
    partial class TicketsFiltrationForm
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
            this.lb_price1stClass = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_priceBusiness = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_priceEco = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numeric_1stClass = new System.Windows.Forms.NumericUpDown();
            this.numeric_business = new System.Windows.Forms.NumericUpDown();
            this.numeric_eco = new System.Windows.Forms.NumericUpDown();
            this.lb_count1stClass = new System.Windows.Forms.Label();
            this.lb_countBusiness = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_countEco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_1stClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_business)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_eco)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_price1stClass);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lb_priceBusiness);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_priceEco);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_buy);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(50, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // lb_price1stClass
            // 
            this.lb_price1stClass.Location = new System.Drawing.Point(552, 79);
            this.lb_price1stClass.Name = "lb_price1stClass";
            this.lb_price1stClass.Size = new System.Drawing.Size(23, 27);
            this.lb_price1stClass.TabIndex = 15;
            this.lb_price1stClass.Text = "0";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(414, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 27);
            this.label12.TabIndex = 14;
            this.label12.Text = "1-st class:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(256, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 27);
            this.label11.TabIndex = 13;
            this.label11.Text = "business:";
            // 
            // lb_priceBusiness
            // 
            this.lb_priceBusiness.Location = new System.Drawing.Point(361, 79);
            this.lb_priceBusiness.Name = "lb_priceBusiness";
            this.lb_priceBusiness.Size = new System.Drawing.Size(23, 27);
            this.lb_priceBusiness.TabIndex = 12;
            this.lb_priceBusiness.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(119, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 27);
            this.label9.TabIndex = 11;
            this.label9.Text = "econom:";
            // 
            // lb_priceEco
            // 
            this.lb_priceEco.Location = new System.Drawing.Point(208, 79);
            this.lb_priceEco.Name = "lb_priceEco";
            this.lb_priceEco.Size = new System.Drawing.Size(23, 27);
            this.lb_priceEco.TabIndex = 10;
            this.lb_priceEco.Text = "0";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(289, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "Price";
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.Gray;
            this.btn_buy.Location = new System.Drawing.Point(444, 309);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(146, 38);
            this.btn_buy.TabIndex = 1;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numeric_1stClass);
            this.groupBox2.Controls.Add(this.numeric_business);
            this.groupBox2.Controls.Add(this.numeric_eco);
            this.groupBox2.Controls.Add(this.lb_count1stClass);
            this.groupBox2.Controls.Add(this.lb_countBusiness);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lb_countEco);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(124, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 165);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Count of each class";
            // 
            // numeric_1stClass
            // 
            this.numeric_1stClass.Location = new System.Drawing.Point(295, 97);
            this.numeric_1stClass.Name = "numeric_1stClass";
            this.numeric_1stClass.Size = new System.Drawing.Size(88, 30);
            this.numeric_1stClass.TabIndex = 8;
            // 
            // numeric_business
            // 
            this.numeric_business.Location = new System.Drawing.Point(171, 97);
            this.numeric_business.Name = "numeric_business";
            this.numeric_business.Size = new System.Drawing.Size(89, 30);
            this.numeric_business.TabIndex = 7;
            // 
            // numeric_eco
            // 
            this.numeric_eco.Location = new System.Drawing.Point(33, 97);
            this.numeric_eco.Name = "numeric_eco";
            this.numeric_eco.Size = new System.Drawing.Size(94, 30);
            this.numeric_eco.TabIndex = 6;
            // 
            // lb_count1stClass
            // 
            this.lb_count1stClass.Location = new System.Drawing.Point(364, 38);
            this.lb_count1stClass.Name = "lb_count1stClass";
            this.lb_count1stClass.Size = new System.Drawing.Size(32, 27);
            this.lb_count1stClass.TabIndex = 5;
            this.lb_count1stClass.Text = "0";
            // 
            // lb_countBusiness
            // 
            this.lb_countBusiness.Location = new System.Drawing.Point(237, 38);
            this.lb_countBusiness.Name = "lb_countBusiness";
            this.lb_countBusiness.Size = new System.Drawing.Size(23, 27);
            this.lb_countBusiness.TabIndex = 4;
            this.lb_countBusiness.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(290, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Count:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(166, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Count:";
            // 
            // lb_countEco
            // 
            this.lb_countEco.Location = new System.Drawing.Point(101, 38);
            this.lb_countEco.Name = "lb_countEco";
            this.lb_countEco.Size = new System.Drawing.Size(33, 27);
            this.lb_countEco.TabIndex = 1;
            this.lb_countEco.Text = "0";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count:";
            // 
            // TicketsFiltrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "TicketsFiltrationForm";
            this.Text = "TicketsFiltrationForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_1stClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_business)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_eco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_countEco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_1stClass;
        private System.Windows.Forms.NumericUpDown numeric_business;
        private System.Windows.Forms.NumericUpDown numeric_eco;
        private System.Windows.Forms.Label lb_count1stClass;
        private System.Windows.Forms.Label lb_countBusiness;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_priceEco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_price1stClass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_priceBusiness;
    }
}