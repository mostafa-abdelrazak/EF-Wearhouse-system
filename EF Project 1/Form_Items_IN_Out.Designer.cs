namespace EF_Project_1
{
    partial class Form_Items_IN_Out
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
            this.Btn_Display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Wearhouse = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_End_Date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_Start_Date = new System.Windows.Forms.DateTimePicker();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Display
            // 
            this.Btn_Display.Location = new System.Drawing.Point(465, 842);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(243, 66);
            this.Btn_Display.TabIndex = 156;
            this.Btn_Display.Text = "Display";
            this.Btn_Display.UseVisualStyleBackColor = true;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1365, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1995, 1005);
            this.dataGridView1.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 152;
            this.label1.Text = "Select Wearhouse";
            // 
            // comboBox_Wearhouse
            // 
            this.comboBox_Wearhouse.FormattingEnabled = true;
            this.comboBox_Wearhouse.Location = new System.Drawing.Point(732, 270);
            this.comboBox_Wearhouse.Name = "comboBox_Wearhouse";
            this.comboBox_Wearhouse.Size = new System.Drawing.Size(219, 39);
            this.comboBox_Wearhouse.TabIndex = 151;
            this.comboBox_Wearhouse.SelectedIndexChanged += new System.EventHandler(this.comboBox_Wearhouse_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 546);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 32);
            this.label6.TabIndex = 149;
            this.label6.Text = "To";
            // 
            // dateTimePicker_End_Date
            // 
            this.dateTimePicker_End_Date.Location = new System.Drawing.Point(567, 540);
            this.dateTimePicker_End_Date.Name = "dateTimePicker_End_Date";
            this.dateTimePicker_End_Date.Size = new System.Drawing.Size(525, 38);
            this.dateTimePicker_End_Date.TabIndex = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 147;
            this.label2.Text = "From";
            // 
            // dateTimePicker_Start_Date
            // 
            this.dateTimePicker_Start_Date.Location = new System.Drawing.Point(567, 422);
            this.dateTimePicker_Start_Date.Name = "dateTimePicker_Start_Date";
            this.dateTimePicker_Start_Date.Size = new System.Drawing.Size(525, 38);
            this.dateTimePicker_Start_Date.TabIndex = 148;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(276, 1031);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(800, 284);
            this.checkedListBox1.TabIndex = 157;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form_Items_IN_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3522, 1485);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Wearhouse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_End_Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_Start_Date);
            this.Name = "Form_Items_IN_Out";
            this.Text = "Items IN Out Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Items_IN_Out_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Wearhouse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start_Date;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}