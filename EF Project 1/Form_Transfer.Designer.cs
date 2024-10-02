namespace EF_Project_1
{
    partial class Form_Transfer
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
            this.Tbox_IN_Wearhouse_Name = new System.Windows.Forms.TextBox();
            this.Tbox_Out_Wearhouse_Name = new System.Windows.Forms.TextBox();
            this.Tbox_Out_Wearhouse_Id = new System.Windows.Forms.TextBox();
            this.Tbox_IN_Wearhouse_ID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_IN_Wearhouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Out_Wearhouse = new System.Windows.Forms.ComboBox();
            this.Tbox_Supplier_Name = new System.Windows.Forms.TextBox();
            this.Tbox_Item_Name = new System.Windows.Forms.TextBox();
            this.Tbox_Item_ID = new System.Windows.Forms.TextBox();
            this.Tbox_Supplier_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Item = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_ExDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_PDate = new System.Windows.Forms.DateTimePicker();
            this.Tbox_Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Transfer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbox_IN_Wearhouse_Name
            // 
            this.Tbox_IN_Wearhouse_Name.Location = new System.Drawing.Point(879, 179);
            this.Tbox_IN_Wearhouse_Name.Name = "Tbox_IN_Wearhouse_Name";
            this.Tbox_IN_Wearhouse_Name.ReadOnly = true;
            this.Tbox_IN_Wearhouse_Name.Size = new System.Drawing.Size(147, 38);
            this.Tbox_IN_Wearhouse_Name.TabIndex = 126;
            this.Tbox_IN_Wearhouse_Name.TextChanged += new System.EventHandler(this.Tbox_Person_Name_TextChanged);
            // 
            // Tbox_Out_Wearhouse_Name
            // 
            this.Tbox_Out_Wearhouse_Name.Location = new System.Drawing.Point(879, 67);
            this.Tbox_Out_Wearhouse_Name.Name = "Tbox_Out_Wearhouse_Name";
            this.Tbox_Out_Wearhouse_Name.ReadOnly = true;
            this.Tbox_Out_Wearhouse_Name.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Out_Wearhouse_Name.TabIndex = 125;
            this.Tbox_Out_Wearhouse_Name.TextChanged += new System.EventHandler(this.Tbox_Item_name_TextChanged);
            // 
            // Tbox_Out_Wearhouse_Id
            // 
            this.Tbox_Out_Wearhouse_Id.Location = new System.Drawing.Point(408, 66);
            this.Tbox_Out_Wearhouse_Id.Name = "Tbox_Out_Wearhouse_Id";
            this.Tbox_Out_Wearhouse_Id.ReadOnly = true;
            this.Tbox_Out_Wearhouse_Id.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Out_Wearhouse_Id.TabIndex = 123;
            this.Tbox_Out_Wearhouse_Id.TextChanged += new System.EventHandler(this.Tbox_Item_Select_TextChanged);
            // 
            // Tbox_IN_Wearhouse_ID
            // 
            this.Tbox_IN_Wearhouse_ID.Location = new System.Drawing.Point(408, 178);
            this.Tbox_IN_Wearhouse_ID.Name = "Tbox_IN_Wearhouse_ID";
            this.Tbox_IN_Wearhouse_ID.ReadOnly = true;
            this.Tbox_IN_Wearhouse_ID.Size = new System.Drawing.Size(147, 38);
            this.Tbox_IN_Wearhouse_ID.TabIndex = 124;
            this.Tbox_IN_Wearhouse_ID.TextChanged += new System.EventHandler(this.Tbox_Person_Select_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 32);
            this.label10.TabIndex = 122;
            this.label10.Text = "Select IN Wearhouse";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBox_IN_Wearhouse
            // 
            this.comboBox_IN_Wearhouse.FormattingEnabled = true;
            this.comboBox_IN_Wearhouse.Location = new System.Drawing.Point(618, 178);
            this.comboBox_IN_Wearhouse.Name = "comboBox_IN_Wearhouse";
            this.comboBox_IN_Wearhouse.Size = new System.Drawing.Size(219, 39);
            this.comboBox_IN_Wearhouse.TabIndex = 121;
            this.comboBox_IN_Wearhouse.SelectedIndexChanged += new System.EventHandler(this.comboBox_Person_Select_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 120;
            this.label1.Text = "Select Out Wearhouse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_Out_Wearhouse
            // 
            this.comboBox_Out_Wearhouse.FormattingEnabled = true;
            this.comboBox_Out_Wearhouse.Location = new System.Drawing.Point(618, 66);
            this.comboBox_Out_Wearhouse.Name = "comboBox_Out_Wearhouse";
            this.comboBox_Out_Wearhouse.Size = new System.Drawing.Size(219, 39);
            this.comboBox_Out_Wearhouse.TabIndex = 119;
            this.comboBox_Out_Wearhouse.SelectedIndexChanged += new System.EventHandler(this.comboBox_Item_Select_SelectedIndexChanged);
            // 
            // Tbox_Supplier_Name
            // 
            this.Tbox_Supplier_Name.Location = new System.Drawing.Point(1037, 610);
            this.Tbox_Supplier_Name.Name = "Tbox_Supplier_Name";
            this.Tbox_Supplier_Name.ReadOnly = true;
            this.Tbox_Supplier_Name.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Supplier_Name.TabIndex = 136;
            // 
            // Tbox_Item_Name
            // 
            this.Tbox_Item_Name.Location = new System.Drawing.Point(1037, 498);
            this.Tbox_Item_Name.Name = "Tbox_Item_Name";
            this.Tbox_Item_Name.ReadOnly = true;
            this.Tbox_Item_Name.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Item_Name.TabIndex = 135;
            // 
            // Tbox_Item_ID
            // 
            this.Tbox_Item_ID.Location = new System.Drawing.Point(566, 497);
            this.Tbox_Item_ID.Name = "Tbox_Item_ID";
            this.Tbox_Item_ID.ReadOnly = true;
            this.Tbox_Item_ID.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Item_ID.TabIndex = 133;
            // 
            // Tbox_Supplier_ID
            // 
            this.Tbox_Supplier_ID.Location = new System.Drawing.Point(566, 609);
            this.Tbox_Supplier_ID.Name = "Tbox_Supplier_ID";
            this.Tbox_Supplier_ID.ReadOnly = true;
            this.Tbox_Supplier_ID.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Supplier_ID.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 32);
            this.label2.TabIndex = 132;
            this.label2.Text = "Select Supplier";
            // 
            // comboBox_Supplier
            // 
            this.comboBox_Supplier.FormattingEnabled = true;
            this.comboBox_Supplier.Location = new System.Drawing.Point(776, 609);
            this.comboBox_Supplier.Name = "comboBox_Supplier";
            this.comboBox_Supplier.Size = new System.Drawing.Size(219, 39);
            this.comboBox_Supplier.TabIndex = 131;
            this.comboBox_Supplier.SelectedIndexChanged += new System.EventHandler(this.comboBox_Supplier_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 130;
            this.label3.Text = "Select Item";
            // 
            // comboBox_Item
            // 
            this.comboBox_Item.FormattingEnabled = true;
            this.comboBox_Item.Location = new System.Drawing.Point(776, 497);
            this.comboBox_Item.Name = "comboBox_Item";
            this.comboBox_Item.Size = new System.Drawing.Size(219, 39);
            this.comboBox_Item.TabIndex = 129;
            this.comboBox_Item.SelectedIndexChanged += new System.EventHandler(this.comboBox_Item_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 978);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 32);
            this.label6.TabIndex = 141;
            this.label6.Text = "Expiration Date";
            // 
            // dateTimePicker_ExDate
            // 
            this.dateTimePicker_ExDate.Location = new System.Drawing.Point(566, 972);
            this.dateTimePicker_ExDate.Name = "dateTimePicker_ExDate";
            this.dateTimePicker_ExDate.Size = new System.Drawing.Size(525, 38);
            this.dateTimePicker_ExDate.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 854);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 32);
            this.label4.TabIndex = 139;
            this.label4.Text = "Production Date";
            // 
            // dateTimePicker_PDate
            // 
            this.dateTimePicker_PDate.Location = new System.Drawing.Point(566, 854);
            this.dateTimePicker_PDate.Name = "dateTimePicker_PDate";
            this.dateTimePicker_PDate.Size = new System.Drawing.Size(525, 38);
            this.dateTimePicker_PDate.TabIndex = 140;
            // 
            // Tbox_Amount
            // 
            this.Tbox_Amount.Location = new System.Drawing.Point(566, 746);
            this.Tbox_Amount.Name = "Tbox_Amount";
            this.Tbox_Amount.Size = new System.Drawing.Size(429, 38);
            this.Tbox_Amount.TabIndex = 137;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 746);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 32);
            this.label7.TabIndex = 138;
            this.label7.Text = "Enter Amount";
            // 
            // Btn_Transfer
            // 
            this.Btn_Transfer.Location = new System.Drawing.Point(614, 1219);
            this.Btn_Transfer.Name = "Btn_Transfer";
            this.Btn_Transfer.Size = new System.Drawing.Size(243, 66);
            this.Btn_Transfer.TabIndex = 143;
            this.Btn_Transfer.Text = "Transfer";
            this.Btn_Transfer.UseVisualStyleBackColor = true;
            this.Btn_Transfer.Click += new System.EventHandler(this.Btn_Transfer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1507, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1411, 608);
            this.dataGridView1.TabIndex = 144;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1501, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 32);
            this.label5.TabIndex = 145;
            this.label5.Text = "Selected Items";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Out_Wearhouse);
            this.groupBox1.Controls.Add(this.comboBox_IN_Wearhouse);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Tbox_IN_Wearhouse_ID);
            this.groupBox1.Controls.Add(this.Tbox_Out_Wearhouse_Id);
            this.groupBox1.Controls.Add(this.Tbox_Out_Wearhouse_Name);
            this.groupBox1.Controls.Add(this.Tbox_IN_Wearhouse_Name);
            this.groupBox1.Location = new System.Drawing.Point(158, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1115, 285);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(2892, 889);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3129, 1470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Transfer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_ExDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_PDate);
            this.Controls.Add(this.Tbox_Amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tbox_Supplier_Name);
            this.Controls.Add(this.Tbox_Item_Name);
            this.Controls.Add(this.Tbox_Item_ID);
            this.Controls.Add(this.Tbox_Supplier_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Supplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Item);
            this.Name = "Form_Transfer";
            this.Text = "Transfer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Transfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tbox_IN_Wearhouse_Name;
        private System.Windows.Forms.TextBox Tbox_Out_Wearhouse_Name;
        private System.Windows.Forms.TextBox Tbox_Out_Wearhouse_Id;
        private System.Windows.Forms.TextBox Tbox_IN_Wearhouse_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_IN_Wearhouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Out_Wearhouse;
        private System.Windows.Forms.TextBox Tbox_Supplier_Name;
        private System.Windows.Forms.TextBox Tbox_Item_Name;
        private System.Windows.Forms.TextBox Tbox_Item_ID;
        private System.Windows.Forms.TextBox Tbox_Supplier_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Item;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ExDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PDate;
        private System.Windows.Forms.TextBox Tbox_Amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Transfer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}