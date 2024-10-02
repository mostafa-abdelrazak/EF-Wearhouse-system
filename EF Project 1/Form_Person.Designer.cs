namespace EF_Project_1
{
    partial class Form_Person
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
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbox_ID = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox_Phone = new System.Windows.Forms.TextBox();
            this.Tbox_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Display = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tbox_Mobile = new System.Windows.Forms.TextBox();
            this.Tbox_Fax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tbox_Website = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tbox_Email = new System.Windows.Forms.TextBox();
            this.radio_Supplier = new System.Windows.Forms.RadioButton();
            this.radio_Client = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1368, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "Supplier/Client";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(913, 1252);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(243, 66);
            this.Btn_Delete.TabIndex = 46;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(566, 1252);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(243, 66);
            this.Btn_Update.TabIndex = 45;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 563);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 32);
            this.label5.TabIndex = 44;
            this.label5.Text = "ID";
            // 
            // Tbox_ID
            // 
            this.Tbox_ID.Location = new System.Drawing.Point(414, 538);
            this.Tbox_ID.Name = "Tbox_ID";
            this.Tbox_ID.ReadOnly = true;
            this.Tbox_ID.Size = new System.Drawing.Size(251, 38);
            this.Tbox_ID.TabIndex = 43;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(222, 1252);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(243, 66);
            this.Btn_Add.TabIndex = 42;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "Select Supplier/Client";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(727, 401);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(429, 39);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 770);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name";
            // 
            // Tbox_Phone
            // 
            this.Tbox_Phone.Location = new System.Drawing.Point(414, 767);
            this.Tbox_Phone.Name = "Tbox_Phone";
            this.Tbox_Phone.Size = new System.Drawing.Size(251, 38);
            this.Tbox_Phone.TabIndex = 37;
            // 
            // Tbox_name
            // 
            this.Tbox_name.Location = new System.Drawing.Point(414, 651);
            this.Tbox_name.Name = "Tbox_name";
            this.Tbox_name.Size = new System.Drawing.Size(251, 38);
            this.Tbox_name.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1354, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(2212, 853);
            this.dataGridView1.TabIndex = 35;
            // 
            // Btn_Display
            // 
            this.Btn_Display.Location = new System.Drawing.Point(2277, 1222);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(243, 66);
            this.Btn_Display.TabIndex = 34;
            this.Btn_Display.Text = "Display";
            this.Btn_Display.UseVisualStyleBackColor = true;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 1013);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 32);
            this.label6.TabIndex = 51;
            this.label6.Text = "Mobile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 894);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 32);
            this.label7.TabIndex = 50;
            this.label7.Text = "Fax";
            // 
            // Tbox_Mobile
            // 
            this.Tbox_Mobile.Location = new System.Drawing.Point(414, 1010);
            this.Tbox_Mobile.Name = "Tbox_Mobile";
            this.Tbox_Mobile.Size = new System.Drawing.Size(251, 38);
            this.Tbox_Mobile.TabIndex = 49;
            // 
            // Tbox_Fax
            // 
            this.Tbox_Fax.Location = new System.Drawing.Point(414, 894);
            this.Tbox_Fax.Name = "Tbox_Fax";
            this.Tbox_Fax.Size = new System.Drawing.Size(251, 38);
            this.Tbox_Fax.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(754, 864);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 32);
            this.label8.TabIndex = 57;
            this.label8.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(745, 684);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 32);
            this.label9.TabIndex = 56;
            this.label9.Text = "Website";
            // 
            // Tbox_Website
            // 
            this.Tbox_Website.Location = new System.Drawing.Point(1040, 684);
            this.Tbox_Website.Name = "Tbox_Website";
            this.Tbox_Website.Size = new System.Drawing.Size(251, 38);
            this.Tbox_Website.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(745, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 32);
            this.label10.TabIndex = 53;
            this.label10.Text = "Email";
            // 
            // Tbox_Email
            // 
            this.Tbox_Email.Location = new System.Drawing.Point(1040, 557);
            this.Tbox_Email.Name = "Tbox_Email";
            this.Tbox_Email.Size = new System.Drawing.Size(251, 38);
            this.Tbox_Email.TabIndex = 52;
            // 
            // radio_Supplier
            // 
            this.radio_Supplier.AutoSize = true;
            this.radio_Supplier.Location = new System.Drawing.Point(1040, 860);
            this.radio_Supplier.Name = "radio_Supplier";
            this.radio_Supplier.Size = new System.Drawing.Size(157, 36);
            this.radio_Supplier.TabIndex = 58;
            this.radio_Supplier.TabStop = true;
            this.radio_Supplier.Text = "Supplier";
            this.radio_Supplier.UseVisualStyleBackColor = true;
            // 
            // radio_Client
            // 
            this.radio_Client.AutoSize = true;
            this.radio_Client.Location = new System.Drawing.Point(1040, 939);
            this.radio_Client.Name = "radio_Client";
            this.radio_Client.Size = new System.Drawing.Size(125, 36);
            this.radio_Client.TabIndex = 59;
            this.radio_Client.TabStop = true;
            this.radio_Client.Text = "Client";
            this.radio_Client.UseVisualStyleBackColor = true;
            // 
            // Form_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3578, 1498);
            this.Controls.Add(this.radio_Client);
            this.Controls.Add(this.radio_Supplier);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Tbox_Website);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Tbox_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tbox_Mobile);
            this.Controls.Add(this.Tbox_Fax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tbox_ID);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbox_Phone);
            this.Controls.Add(this.Tbox_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Display);
            this.Name = "Form_Person";
            this.Text = "Supplier/Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Person_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbox_ID;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbox_Phone;
        private System.Windows.Forms.TextBox Tbox_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Display;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tbox_Mobile;
        private System.Windows.Forms.TextBox Tbox_Fax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tbox_Website;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tbox_Email;
        private System.Windows.Forms.RadioButton radio_Supplier;
        private System.Windows.Forms.RadioButton radio_Client;
    }
}