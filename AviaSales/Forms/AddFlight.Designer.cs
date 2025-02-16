namespace AviaSales.Forms
{
    partial class AddFlight
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_arriving = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.tb_destinati = new System.Windows.Forms.TextBox();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.numeric_flight = new System.Windows.Forms.NumericUpDown();
            this.numeric_planes = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeric_FirstClassPrice = new System.Windows.Forms.NumericUpDown();
            this.numeric_businessPrice = new System.Windows.Forms.NumericUpDown();
            this.numeric_economyPrice = new System.Windows.Forms.NumericUpDown();
            this.numeric_firstClassCount = new System.Windows.Forms.NumericUpDown();
            this.numeric_businessCount = new System.Windows.Forms.NumericUpDown();
            this.numericU_economyCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_flight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_planes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_FirstClassPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_businessPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_economyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_firstClassCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_businessCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericU_economyCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.groupBox);
            this.panel2.Location = new System.Drawing.Point(139, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 492);
            this.panel2.TabIndex = 5;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dateTimePicker_arriving);
            this.groupBox.Controls.Add(this.dateTimePicker_date);
            this.groupBox.Controls.Add(this.tb_destinati);
            this.groupBox.Controls.Add(this.tb_from);
            this.groupBox.Controls.Add(this.numeric_flight);
            this.groupBox.Controls.Add(this.numeric_planes);
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.btn_Save);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(23, 27);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(603, 453);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Flight";
            // 
            // dateTimePicker_arriving
            // 
            this.dateTimePicker_arriving.Location = new System.Drawing.Point(136, 206);
            this.dateTimePicker_arriving.Name = "dateTimePicker_arriving";
            this.dateTimePicker_arriving.Size = new System.Drawing.Size(382, 30);
            this.dateTimePicker_arriving.TabIndex = 31;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(136, 162);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(382, 30);
            this.dateTimePicker_date.TabIndex = 30;
            // 
            // tb_destinati
            // 
            this.tb_destinati.Location = new System.Drawing.Point(136, 118);
            this.tb_destinati.Multiline = true;
            this.tb_destinati.Name = "tb_destinati";
            this.tb_destinati.Size = new System.Drawing.Size(382, 34);
            this.tb_destinati.TabIndex = 29;
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(136, 78);
            this.tb_from.Multiline = true;
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(382, 33);
            this.tb_from.TabIndex = 28;
            // 
            // numeric_flight
            // 
            this.numeric_flight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numeric_flight.Location = new System.Drawing.Point(419, 42);
            this.numeric_flight.Name = "numeric_flight";
            this.numeric_flight.Size = new System.Drawing.Size(99, 30);
            this.numeric_flight.TabIndex = 27;
            // 
            // numeric_planes
            // 
            this.numeric_planes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numeric_planes.Location = new System.Drawing.Point(136, 42);
            this.numeric_planes.Name = "numeric_planes";
            this.numeric_planes.Size = new System.Drawing.Size(99, 30);
            this.numeric_planes.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numeric_FirstClassPrice);
            this.groupBox1.Controls.Add(this.numeric_businessPrice);
            this.groupBox1.Controls.Add(this.numeric_economyPrice);
            this.groupBox1.Controls.Add(this.numeric_firstClassCount);
            this.groupBox1.Controls.Add(this.numeric_businessCount);
            this.groupBox1.Controls.Add(this.numericU_economyCount);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(23, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 161);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // numeric_FirstClassPrice
            // 
            this.numeric_FirstClassPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numeric_FirstClassPrice.Location = new System.Drawing.Point(396, 107);
            this.numeric_FirstClassPrice.Name = "numeric_FirstClassPrice";
            this.numeric_FirstClassPrice.Size = new System.Drawing.Size(99, 30);
            this.numeric_FirstClassPrice.TabIndex = 25;
            // 
            // numeric_businessPrice
            // 
            this.numeric_businessPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numeric_businessPrice.Location = new System.Drawing.Point(396, 67);
            this.numeric_businessPrice.Name = "numeric_businessPrice";
            this.numeric_businessPrice.Size = new System.Drawing.Size(99, 30);
            this.numeric_businessPrice.TabIndex = 24;
            // 
            // numeric_economyPrice
            // 
            this.numeric_economyPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numeric_economyPrice.Location = new System.Drawing.Point(396, 20);
            this.numeric_economyPrice.Name = "numeric_economyPrice";
            this.numeric_economyPrice.Size = new System.Drawing.Size(99, 30);
            this.numeric_economyPrice.TabIndex = 23;
            // 
            // numeric_firstClassCount
            // 
            this.numeric_firstClassCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numeric_firstClassCount.Location = new System.Drawing.Point(173, 98);
            this.numeric_firstClassCount.Name = "numeric_firstClassCount";
            this.numeric_firstClassCount.Size = new System.Drawing.Size(99, 30);
            this.numeric_firstClassCount.TabIndex = 22;
            // 
            // numeric_businessCount
            // 
            this.numeric_businessCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numeric_businessCount.Location = new System.Drawing.Point(173, 59);
            this.numeric_businessCount.Name = "numeric_businessCount";
            this.numeric_businessCount.Size = new System.Drawing.Size(99, 30);
            this.numeric_businessCount.TabIndex = 21;
            // 
            // numericU_economyCount
            // 
            this.numericU_economyCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numericU_economyCount.Location = new System.Drawing.Point(173, 20);
            this.numericU_economyCount.Name = "numericU_economyCount";
            this.numericU_economyCount.Size = new System.Drawing.Size(99, 30);
            this.numericU_economyCount.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(307, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Price:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(307, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "Price:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(307, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Price:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(25, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 33);
            this.label9.TabIndex = 16;
            this.label9.Text = "First class count:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 33);
            this.label8.TabIndex = 15;
            this.label8.Text = "Business count:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "Economy count:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(297, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 53);
            this.label6.TabIndex = 12;
            this.label6.Text = "Flight`s:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Arriving:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destinati:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "From:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 53);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plane`s";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_Save.Location = new System.Drawing.Point(450, 409);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(135, 44);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(896, 568);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "AddFlight";
            this.Text = "Add flight";
            this.panel2.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_flight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_planes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_FirstClassPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_businessPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_economyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_firstClassCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_businessCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericU_economyCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_destinati;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.NumericUpDown numeric_flight;
        private System.Windows.Forms.NumericUpDown numeric_planes;
        private System.Windows.Forms.NumericUpDown numeric_FirstClassPrice;
        private System.Windows.Forms.NumericUpDown numeric_businessPrice;
        private System.Windows.Forms.NumericUpDown numeric_economyPrice;
        private System.Windows.Forms.NumericUpDown numeric_firstClassCount;
        private System.Windows.Forms.NumericUpDown numeric_businessCount;
        private System.Windows.Forms.NumericUpDown numericU_economyCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker_arriving;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
    }
}