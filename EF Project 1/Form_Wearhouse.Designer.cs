namespace EF_Project_1
{
    partial class Form_Wearhouse
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
            this.Tbox_name = new System.Windows.Forms.TextBox();
            this.Tbox_Address = new System.Windows.Forms.TextBox();
            this.Tbox_Supervisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbox_ID = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Display
            // 
            this.Btn_Display.Location = new System.Drawing.Point(2347, 1123);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(243, 66);
            this.Btn_Display.TabIndex = 0;
            this.Btn_Display.Text = "Display";
            this.Btn_Display.UseVisualStyleBackColor = true;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1365, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1392, 853);
            this.dataGridView1.TabIndex = 1;
            // 
            // Tbox_name
            // 
            this.Tbox_name.Location = new System.Drawing.Point(853, 407);
            this.Tbox_name.Name = "Tbox_name";
            this.Tbox_name.Size = new System.Drawing.Size(251, 38);
            this.Tbox_name.TabIndex = 3;
            // 
            // Tbox_Address
            // 
            this.Tbox_Address.Location = new System.Drawing.Point(853, 523);
            this.Tbox_Address.Name = "Tbox_Address";
            this.Tbox_Address.Size = new System.Drawing.Size(251, 38);
            this.Tbox_Address.TabIndex = 6;
            // 
            // Tbox_Supervisor
            // 
            this.Tbox_Supervisor.Location = new System.Drawing.Point(853, 671);
            this.Tbox_Supervisor.Name = "Tbox_Supervisor";
            this.Tbox_Supervisor.Size = new System.Drawing.Size(251, 38);
            this.Tbox_Supervisor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 674);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Supervisor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(675, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(429, 39);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select Warehouse";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(286, 1036);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(243, 66);
            this.Btn_Add.TabIndex = 13;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tbox_ID
            // 
            this.Tbox_ID.Location = new System.Drawing.Point(853, 319);
            this.Tbox_ID.Name = "Tbox_ID";
            this.Tbox_ID.ReadOnly = true;
            this.Tbox_ID.Size = new System.Drawing.Size(251, 38);
            this.Tbox_ID.TabIndex = 14;
            this.Tbox_ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(630, 1036);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(243, 66);
            this.Btn_Update.TabIndex = 16;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(977, 1036);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(243, 66);
            this.Btn_Delete.TabIndex = 17;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1386, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Warehouses";
            // 
            // Form_Wearhouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2861, 1488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tbox_ID);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbox_Supervisor);
            this.Controls.Add(this.Tbox_Address);
            this.Controls.Add(this.Tbox_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Display);
            this.Name = "Form_Wearhouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Warehouses";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Wearhouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Tbox_name;
        private System.Windows.Forms.TextBox Tbox_Address;
        private System.Windows.Forms.TextBox Tbox_Supervisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbox_ID;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Label label6;
    }
}