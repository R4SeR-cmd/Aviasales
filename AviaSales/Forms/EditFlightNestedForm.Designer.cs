namespace AviaSales.Forms
{
    partial class EditFlightNestedForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_arriving = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.tb_destinati = new System.Windows.Forms.TextBox();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.numeric_flight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_flight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dateTimePicker_arriving);
            this.groupBox.Controls.Add(this.dateTimePicker_date);
            this.groupBox.Controls.Add(this.tb_destinati);
            this.groupBox.Controls.Add(this.tb_from);
            this.groupBox.Controls.Add(this.numeric_flight);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.btn_Save);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(111, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(600, 446);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Edit flight";
            // 
            // dateTimePicker_arriving
            // 
            this.dateTimePicker_arriving.Location = new System.Drawing.Point(153, 312);
            this.dateTimePicker_arriving.Name = "dateTimePicker_arriving";
            this.dateTimePicker_arriving.Size = new System.Drawing.Size(382, 30);
            this.dateTimePicker_arriving.TabIndex = 31;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(153, 244);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(382, 30);
            this.dateTimePicker_date.TabIndex = 30;
            // 
            // tb_destinati
            // 
            this.tb_destinati.Location = new System.Drawing.Point(153, 183);
            this.tb_destinati.Multiline = true;
            this.tb_destinati.Name = "tb_destinati";
            this.tb_destinati.Size = new System.Drawing.Size(382, 34);
            this.tb_destinati.TabIndex = 29;
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(153, 112);
            this.tb_from.Multiline = true;
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(382, 33);
            this.tb_from.TabIndex = 28;
            // 
            // numeric_flight
            // 
            this.numeric_flight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numeric_flight.Location = new System.Drawing.Point(153, 45);
            this.numeric_flight.Name = "numeric_flight";
            this.numeric_flight.Size = new System.Drawing.Size(99, 30);
            this.numeric_flight.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 53);
            this.label6.TabIndex = 12;
            this.label6.Text = "Flight`s:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Arriving:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Destinati:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "From:";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_Save.Location = new System.Drawing.Point(450, 396);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(135, 44);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // EditFlightNestedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Name = "EditFlightNestedForm";
            this.Text = "EditFlightNestedForm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_flight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker_arriving;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.TextBox tb_destinati;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.NumericUpDown numeric_flight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
    }
}