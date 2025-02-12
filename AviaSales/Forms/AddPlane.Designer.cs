namespace AviaSales.Forms
{
    partial class AddPlane
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
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.numeric_ID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.groupBox);
            this.panel2.Location = new System.Drawing.Point(141, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 492);
            this.panel2.TabIndex = 5;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btn_add);
            this.groupBox.Controls.Add(this.tb_name);
            this.groupBox.Controls.Add(this.numeric_ID);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(82, 60);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(501, 336);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Plane creation";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btn_add.Location = new System.Drawing.Point(301, 257);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(147, 44);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(182, 173);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(266, 36);
            this.tb_name.TabIndex = 3;
            // 
            // numeric_ID
            // 
            this.numeric_ID.BackColor = System.Drawing.Color.White;
            this.numeric_ID.Location = new System.Drawing.Point(182, 89);
            this.numeric_ID.Name = "numeric_ID";
            this.numeric_ID.Size = new System.Drawing.Size(266, 30);
            this.numeric_ID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(56, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name of";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ID of";
            // 
            // AddPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(969, 511);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "AddPlane";
            this.Text = "Add plane";
            this.panel2.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.NumericUpDown numeric_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
    }
}