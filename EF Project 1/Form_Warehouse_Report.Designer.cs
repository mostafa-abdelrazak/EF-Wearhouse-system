namespace EF_Project_1
{
    partial class Form_Warehouse_Report
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
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_End_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Wearhouse = new System.Windows.Forms.ComboBox();
            this.Tbox_Wearhouse_Id = new System.Windows.Forms.TextBox();
            this.Tbox_Wearhouse_Name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Display = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 32);
            this.label6.TabIndex = 112;
            this.label6.Text = "To";
            // 
            // dateTimePicker_End_Date
            // 
            this.dateTimePicker_End_Date.Location = new System.Drawing.Point(502, 402);
            this.dateTimePicker_End_Date.Name = "dateTimePicker_End_Date";
            this.dateTimePicker_End_Date.Size = new System.Drawing.Size(525, 38);
            this.dateTimePicker_End_Date.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 110;
            this.label2.Text = "From";
            // 
            // dateTimePicker_Start_Date
            // 
            this.dateTimePicker_Start_Date.Location = new System.Drawing.Point(502, 284);
            this.dateTimePicker_Start_Date.Name = "dateTimePicker_Start_Date";
            this.dateTimePicker_Start_Date.Size = new System.Drawing.Size(525, 38);
            this.dateTimePicker_Start_Date.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 127;
            this.label1.Text = "Select Wearhouse";
            // 
            // comboBox_Wearhouse
            // 
            this.comboBox_Wearhouse.FormattingEnabled = true;
            this.comboBox_Wearhouse.Location = new System.Drawing.Point(667, 132);
            this.comboBox_Wearhouse.Name = "comboBox_Wearhouse";
            this.comboBox_Wearhouse.Size = new System.Drawing.Size(219, 39);
            this.comboBox_Wearhouse.TabIndex = 126;
            this.comboBox_Wearhouse.SelectedIndexChanged += new System.EventHandler(this.comboBox_Wearhouse_SelectedIndexChanged);
            // 
            // Tbox_Wearhouse_Id
            // 
            this.Tbox_Wearhouse_Id.Location = new System.Drawing.Point(457, 132);
            this.Tbox_Wearhouse_Id.Name = "Tbox_Wearhouse_Id";
            this.Tbox_Wearhouse_Id.ReadOnly = true;
            this.Tbox_Wearhouse_Id.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Wearhouse_Id.TabIndex = 128;
            // 
            // Tbox_Wearhouse_Name
            // 
            this.Tbox_Wearhouse_Name.Location = new System.Drawing.Point(928, 133);
            this.Tbox_Wearhouse_Name.Name = "Tbox_Wearhouse_Name";
            this.Tbox_Wearhouse_Name.ReadOnly = true;
            this.Tbox_Wearhouse_Name.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Wearhouse_Name.TabIndex = 129;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1300, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1995, 1005);
            this.dataGridView1.TabIndex = 145;
            // 
            // Btn_Display
            // 
            this.Btn_Display.Location = new System.Drawing.Point(400, 704);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(243, 66);
            this.Btn_Display.TabIndex = 146;
            this.Btn_Display.Text = "Display";
            this.Btn_Display.UseVisualStyleBackColor = true;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // Form_Warehouse_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3332, 1401);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Wearhouse);
            this.Controls.Add(this.Tbox_Wearhouse_Id);
            this.Controls.Add(this.Tbox_Wearhouse_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_End_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_Start_Date);
            this.Name = "Form_Warehouse_Report";
            this.Text = "Warehouse Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Warehouse_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Wearhouse;
        private System.Windows.Forms.TextBox Tbox_Wearhouse_Id;
        private System.Windows.Forms.TextBox Tbox_Wearhouse_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Display;
    }
}