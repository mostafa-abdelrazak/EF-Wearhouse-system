namespace EF_Project_1
{
    partial class Form_Receipt
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
            this.label7 = new System.Windows.Forms.Label();
            this.Tbox_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Delete_Item = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbox_ID = new System.Windows.Forms.TextBox();
            this.Btn_Add_Item = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker_Recipt = new System.Windows.Forms.DateTimePicker();
            this.radioButton_Out = new System.Windows.Forms.RadioButton();
            this.radioButton_IN = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Wearhouse = new System.Windows.Forms.ComboBox();
            this.Tbox_Wearhouse = new System.Windows.Forms.TextBox();
            this.Btn_Add_Receipt = new System.Windows.Forms.Button();
            this.Btn_Delete_Receipt = new System.Windows.Forms.Button();
            this.Btn_Update_Receipt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Update_Item = new System.Windows.Forms.Button();
            this.comboBox_Recit_Item_ID = new System.Windows.Forms.ComboBox();
            this.Tbox_Person_Name = new System.Windows.Forms.TextBox();
            this.Tbox_Item_name = new System.Windows.Forms.TextBox();
            this.Tbox_Item_Select = new System.Windows.Forms.TextBox();
            this.Tbox_Person_Select = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_ExDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_PDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Person_Select = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Item_Select = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 32);
            this.label7.TabIndex = 76;
            this.label7.Text = "Amount";
            // 
            // Tbox_Amount
            // 
            this.Tbox_Amount.Location = new System.Drawing.Point(438, 372);
            this.Tbox_Amount.Name = "Tbox_Amount";
            this.Tbox_Amount.Size = new System.Drawing.Size(429, 38);
            this.Tbox_Amount.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1308, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 73;
            this.label3.Text = "Receipt";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Btn_Delete_Item
            // 
            this.Btn_Delete_Item.Location = new System.Drawing.Point(821, 667);
            this.Btn_Delete_Item.Name = "Btn_Delete_Item";
            this.Btn_Delete_Item.Size = new System.Drawing.Size(243, 66);
            this.Btn_Delete_Item.TabIndex = 72;
            this.Btn_Delete_Item.Text = "Delete";
            this.Btn_Delete_Item.UseVisualStyleBackColor = true;
            this.Btn_Delete_Item.Click += new System.EventHandler(this.Btn_Delete_Item_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 32);
            this.label5.TabIndex = 70;
            this.label5.Text = "Receipt ID";
            // 
            // Tbox_ID
            // 
            this.Tbox_ID.Location = new System.Drawing.Point(322, 155);
            this.Tbox_ID.Name = "Tbox_ID";
            this.Tbox_ID.ReadOnly = true;
            this.Tbox_ID.Size = new System.Drawing.Size(251, 38);
            this.Tbox_ID.TabIndex = 69;
            // 
            // Btn_Add_Item
            // 
            this.Btn_Add_Item.Location = new System.Drawing.Point(120, 667);
            this.Btn_Add_Item.Name = "Btn_Add_Item";
            this.Btn_Add_Item.Size = new System.Drawing.Size(243, 66);
            this.Btn_Add_Item.TabIndex = 68;
            this.Btn_Add_Item.Text = "Add";
            this.Btn_Add_Item.UseVisualStyleBackColor = true;
            this.Btn_Add_Item.Click += new System.EventHandler(this.Btn_Add_Item_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 32);
            this.label4.TabIndex = 67;
            this.label4.Text = "Select Receipt";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(659, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(429, 39);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1294, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(2218, 608);
            this.dataGridView1.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(193, 32);
            this.label12.TabIndex = 88;
            this.label12.Text = "Wearhouse ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 32);
            this.label13.TabIndex = 89;
            this.label13.Text = "Receipt Date";
            // 
            // dateTimePicker_Recipt
            // 
            this.dateTimePicker_Recipt.Location = new System.Drawing.Point(322, 405);
            this.dateTimePicker_Recipt.Name = "dateTimePicker_Recipt";
            this.dateTimePicker_Recipt.Size = new System.Drawing.Size(525, 38);
            this.dateTimePicker_Recipt.TabIndex = 90;
            // 
            // radioButton_Out
            // 
            this.radioButton_Out.AutoSize = true;
            this.radioButton_Out.Location = new System.Drawing.Point(967, 262);
            this.radioButton_Out.Name = "radioButton_Out";
            this.radioButton_Out.Size = new System.Drawing.Size(97, 36);
            this.radioButton_Out.TabIndex = 93;
            this.radioButton_Out.TabStop = true;
            this.radioButton_Out.Text = "Out";
            this.radioButton_Out.UseVisualStyleBackColor = true;
            // 
            // radioButton_IN
            // 
            this.radioButton_IN.AutoSize = true;
            this.radioButton_IN.Location = new System.Drawing.Point(967, 183);
            this.radioButton_IN.Name = "radioButton_IN";
            this.radioButton_IN.Size = new System.Drawing.Size(78, 36);
            this.radioButton_IN.TabIndex = 92;
            this.radioButton_IN.TabStop = true;
            this.radioButton_IN.Text = "IN";
            this.radioButton_IN.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(790, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 32);
            this.label14.TabIndex = 91;
            this.label14.Text = "Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Wearhouse);
            this.groupBox1.Controls.Add(this.Tbox_Wearhouse);
            this.groupBox1.Controls.Add(this.Btn_Add_Receipt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Btn_Delete_Receipt);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Btn_Update_Receipt);
            this.groupBox1.Controls.Add(this.Tbox_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton_Out);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.radioButton_IN);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dateTimePicker_Recipt);
            this.groupBox1.Location = new System.Drawing.Point(59, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 601);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt";
            // 
            // comboBox_Wearhouse
            // 
            this.comboBox_Wearhouse.FormattingEnabled = true;
            this.comboBox_Wearhouse.Location = new System.Drawing.Point(616, 271);
            this.comboBox_Wearhouse.Name = "comboBox_Wearhouse";
            this.comboBox_Wearhouse.Size = new System.Drawing.Size(231, 39);
            this.comboBox_Wearhouse.TabIndex = 111;
            this.comboBox_Wearhouse.SelectedIndexChanged += new System.EventHandler(this.comboBox_Wearhouse_SelectedIndexChanged_1);
            // 
            // Tbox_Wearhouse
            // 
            this.Tbox_Wearhouse.Location = new System.Drawing.Point(322, 271);
            this.Tbox_Wearhouse.Name = "Tbox_Wearhouse";
            this.Tbox_Wearhouse.ReadOnly = true;
            this.Tbox_Wearhouse.Size = new System.Drawing.Size(251, 38);
            this.Tbox_Wearhouse.TabIndex = 110;
            // 
            // Btn_Add_Receipt
            // 
            this.Btn_Add_Receipt.Location = new System.Drawing.Point(120, 498);
            this.Btn_Add_Receipt.Name = "Btn_Add_Receipt";
            this.Btn_Add_Receipt.Size = new System.Drawing.Size(243, 66);
            this.Btn_Add_Receipt.TabIndex = 97;
            this.Btn_Add_Receipt.Text = "Add";
            this.Btn_Add_Receipt.UseVisualStyleBackColor = true;
            this.Btn_Add_Receipt.Click += new System.EventHandler(this.Btn_Add_Receipt_Click);
            // 
            // Btn_Delete_Receipt
            // 
            this.Btn_Delete_Receipt.Location = new System.Drawing.Point(825, 498);
            this.Btn_Delete_Receipt.Name = "Btn_Delete_Receipt";
            this.Btn_Delete_Receipt.Size = new System.Drawing.Size(243, 66);
            this.Btn_Delete_Receipt.TabIndex = 99;
            this.Btn_Delete_Receipt.Text = "Delete";
            this.Btn_Delete_Receipt.UseVisualStyleBackColor = true;
            this.Btn_Delete_Receipt.Click += new System.EventHandler(this.Btn_Delete_Receipt_Click);
            // 
            // Btn_Update_Receipt
            // 
            this.Btn_Update_Receipt.Location = new System.Drawing.Point(478, 498);
            this.Btn_Update_Receipt.Name = "Btn_Update_Receipt";
            this.Btn_Update_Receipt.Size = new System.Drawing.Size(243, 66);
            this.Btn_Update_Receipt.TabIndex = 98;
            this.Btn_Update_Receipt.Text = "Update";
            this.Btn_Update_Receipt.UseVisualStyleBackColor = true;
            this.Btn_Update_Receipt.Click += new System.EventHandler(this.Btn_Update_Receipt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Btn_Update_Item);
            this.groupBox2.Controls.Add(this.comboBox_Recit_Item_ID);
            this.groupBox2.Controls.Add(this.Tbox_Person_Name);
            this.groupBox2.Controls.Add(this.Tbox_Item_name);
            this.groupBox2.Controls.Add(this.Tbox_Item_Select);
            this.groupBox2.Controls.Add(this.Tbox_Person_Select);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePicker_ExDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker_PDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox_Person_Select);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Btn_Add_Item);
            this.groupBox2.Controls.Add(this.comboBox_Item_Select);
            this.groupBox2.Controls.Add(this.Btn_Delete_Item);
            this.groupBox2.Controls.Add(this.Tbox_Amount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(59, 672);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1162, 777);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receipt Items";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 32);
            this.label8.TabIndex = 118;
            this.label8.Text = "Select Items/Receipt  Number";
            // 
            // Btn_Update_Item
            // 
            this.Btn_Update_Item.Location = new System.Drawing.Point(478, 667);
            this.Btn_Update_Item.Name = "Btn_Update_Item";
            this.Btn_Update_Item.Size = new System.Drawing.Size(243, 66);
            this.Btn_Update_Item.TabIndex = 117;
            this.Btn_Update_Item.Text = "Update";
            this.Btn_Update_Item.UseVisualStyleBackColor = true;
            this.Btn_Update_Item.Click += new System.EventHandler(this.Btn_Update_Item_Click);
            // 
            // comboBox_Recit_Item_ID
            // 
            this.comboBox_Recit_Item_ID.FormattingEnabled = true;
            this.comboBox_Recit_Item_ID.Location = new System.Drawing.Point(648, 47);
            this.comboBox_Recit_Item_ID.Name = "comboBox_Recit_Item_ID";
            this.comboBox_Recit_Item_ID.Size = new System.Drawing.Size(219, 39);
            this.comboBox_Recit_Item_ID.TabIndex = 116;
            this.comboBox_Recit_Item_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_Recit_Item_ID_SelectedIndexChanged);
            // 
            // Tbox_Person_Name
            // 
            this.Tbox_Person_Name.Location = new System.Drawing.Point(909, 256);
            this.Tbox_Person_Name.Name = "Tbox_Person_Name";
            this.Tbox_Person_Name.ReadOnly = true;
            this.Tbox_Person_Name.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Person_Name.TabIndex = 115;
            // 
            // Tbox_Item_name
            // 
            this.Tbox_Item_name.Location = new System.Drawing.Point(909, 144);
            this.Tbox_Item_name.Name = "Tbox_Item_name";
            this.Tbox_Item_name.ReadOnly = true;
            this.Tbox_Item_name.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Item_name.TabIndex = 114;
            // 
            // Tbox_Item_Select
            // 
            this.Tbox_Item_Select.Location = new System.Drawing.Point(438, 143);
            this.Tbox_Item_Select.Name = "Tbox_Item_Select";
            this.Tbox_Item_Select.ReadOnly = true;
            this.Tbox_Item_Select.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Item_Select.TabIndex = 112;
            // 
            // Tbox_Person_Select
            // 
            this.Tbox_Person_Select.Location = new System.Drawing.Point(438, 255);
            this.Tbox_Person_Select.Name = "Tbox_Person_Select";
            this.Tbox_Person_Select.ReadOnly = true;
            this.Tbox_Person_Select.Size = new System.Drawing.Size(147, 38);
            this.Tbox_Person_Select.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 604);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 32);
            this.label6.TabIndex = 108;
            this.label6.Text = "Expiration Date";
            // 
            // dateTimePicker_ExDate
            // 
            this.dateTimePicker_ExDate.Location = new System.Drawing.Point(438, 598);
            this.dateTimePicker_ExDate.Name = "dateTimePicker_ExDate";
            this.dateTimePicker_ExDate.Size = new System.Drawing.Size(525, 38);
            this.dateTimePicker_ExDate.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 106;
            this.label2.Text = "Production Date";
            // 
            // dateTimePicker_PDate
            // 
            this.dateTimePicker_PDate.Location = new System.Drawing.Point(438, 480);
            this.dateTimePicker_PDate.Name = "dateTimePicker_PDate";
            this.dateTimePicker_PDate.Size = new System.Drawing.Size(525, 38);
            this.dateTimePicker_PDate.TabIndex = 107;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 32);
            this.label10.TabIndex = 105;
            this.label10.Text = "Select Person";
            // 
            // comboBox_Person_Select
            // 
            this.comboBox_Person_Select.FormattingEnabled = true;
            this.comboBox_Person_Select.Location = new System.Drawing.Point(648, 255);
            this.comboBox_Person_Select.Name = "comboBox_Person_Select";
            this.comboBox_Person_Select.Size = new System.Drawing.Size(219, 39);
            this.comboBox_Person_Select.TabIndex = 104;
            this.comboBox_Person_Select.SelectedIndexChanged += new System.EventHandler(this.comboBox_Person_Select_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 101;
            this.label1.Text = "Select Item Number";
            // 
            // comboBox_Item_Select
            // 
            this.comboBox_Item_Select.FormattingEnabled = true;
            this.comboBox_Item_Select.Location = new System.Drawing.Point(648, 143);
            this.comboBox_Item_Select.Name = "comboBox_Item_Select";
            this.comboBox_Item_Select.Size = new System.Drawing.Size(219, 39);
            this.comboBox_Item_Select.TabIndex = 100;
            this.comboBox_Item_Select.SelectedIndexChanged += new System.EventHandler(this.comboBox_Item_Select_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1308, 740);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 32);
            this.label11.TabIndex = 99;
            this.label11.Text = "Receipt Items";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1294, 797);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(2218, 608);
            this.dataGridView2.TabIndex = 98;
            // 
            // Form_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3566, 1511);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_Receipt";
            this.Text = "`";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tbox_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Delete_Item;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbox_ID;
        private System.Windows.Forms.Button Btn_Add_Item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Recipt;
        private System.Windows.Forms.RadioButton radioButton_Out;
        private System.Windows.Forms.RadioButton radioButton_IN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Add_Receipt;
        private System.Windows.Forms.Button Btn_Delete_Receipt;
        private System.Windows.Forms.Button Btn_Update_Receipt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Person_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Item_Select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ExDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PDate;
        private System.Windows.Forms.TextBox Tbox_Wearhouse;
        private System.Windows.Forms.ComboBox comboBox_Wearhouse;
        private System.Windows.Forms.TextBox Tbox_Item_Select;
        private System.Windows.Forms.TextBox Tbox_Person_Select;
        private System.Windows.Forms.TextBox Tbox_Person_Name;
        private System.Windows.Forms.TextBox Tbox_Item_name;
        private System.Windows.Forms.ComboBox comboBox_Recit_Item_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Update_Item;
    }
}