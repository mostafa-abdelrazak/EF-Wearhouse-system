namespace EF_Project_1
{
    partial class Form_Time_Period_Report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Dispaly = new System.Windows.Forms.Button();
            this.comboBox_Hours = new System.Windows.Forms.ComboBox();
            this.comboBox_Minutes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_months = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_Days = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_Years = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Hours";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(713, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(2716, 1239);
            this.dataGridView1.TabIndex = 6;
            // 
            // Btn_Dispaly
            // 
            this.Btn_Dispaly.Location = new System.Drawing.Point(268, 842);
            this.Btn_Dispaly.Name = "Btn_Dispaly";
            this.Btn_Dispaly.Size = new System.Drawing.Size(254, 84);
            this.Btn_Dispaly.TabIndex = 4;
            this.Btn_Dispaly.Text = "Dispaly";
            this.Btn_Dispaly.UseVisualStyleBackColor = true;
            this.Btn_Dispaly.Click += new System.EventHandler(this.Btn_Dispaly_Click);
            // 
            // comboBox_Hours
            // 
            this.comboBox_Hours.FormattingEnabled = true;
            this.comboBox_Hours.Location = new System.Drawing.Point(490, 306);
            this.comboBox_Hours.Name = "comboBox_Hours";
            this.comboBox_Hours.Size = new System.Drawing.Size(167, 39);
            this.comboBox_Hours.TabIndex = 8;
            this.comboBox_Hours.SelectedIndexChanged += new System.EventHandler(this.comboBox_Hours_SelectedIndexChanged);
            // 
            // comboBox_Minutes
            // 
            this.comboBox_Minutes.FormattingEnabled = true;
            this.comboBox_Minutes.Location = new System.Drawing.Point(490, 397);
            this.comboBox_Minutes.Name = "comboBox_Minutes";
            this.comboBox_Minutes.Size = new System.Drawing.Size(167, 39);
            this.comboBox_Minutes.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Minutes";
            // 
            // combo_months
            // 
            this.combo_months.FormattingEnabled = true;
            this.combo_months.Location = new System.Drawing.Point(490, 581);
            this.combo_months.Name = "combo_months";
            this.combo_months.Size = new System.Drawing.Size(167, 39);
            this.combo_months.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Months";
            // 
            // combo_Days
            // 
            this.combo_Days.FormattingEnabled = true;
            this.combo_Days.Location = new System.Drawing.Point(490, 490);
            this.combo_Days.Name = "combo_Days";
            this.combo_Days.Size = new System.Drawing.Size(167, 39);
            this.combo_Days.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select Days";
            // 
            // combo_Years
            // 
            this.combo_Years.FormattingEnabled = true;
            this.combo_Years.Location = new System.Drawing.Point(490, 685);
            this.combo_Years.Name = "combo_Years";
            this.combo_Years.Size = new System.Drawing.Size(167, 39);
            this.combo_Years.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 685);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select Years";
            // 
            // Form_Time_Period_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3518, 1543);
            this.Controls.Add(this.combo_Years);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_months);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_Days);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Minutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Hours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Dispaly);
            this.Name = "Form_Time_Period_Report";
            this.Text = "Time Period Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Time_Period_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Dispaly;
        private System.Windows.Forms.ComboBox comboBox_Hours;
        private System.Windows.Forms.ComboBox comboBox_Minutes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_months;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_Days;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_Years;
        private System.Windows.Forms.Label label5;
    }
}