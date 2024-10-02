using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project_1
{
    public partial class Form_Receipt : Form
    {
        public Form_Receipt()
        {
            InitializeComponent();
        }
        EF_Model db;
        private void Form_Receipt_Load(object sender, EventArgs e)
        {
            db = new EF_Model();
            var wearhouses_ID = db.Warehouses.Select(x => x.ID);
            foreach (var id in wearhouses_ID)
            {
                comboBox_Wearhouse.Items.Add(id);
            }
            var Items_ID = db.Items.Select(x => x.ID);
            foreach (var id in Items_ID)
            {
                comboBox_Item_Select.Items.Add(id);
            }
            var Persons_ID = db.Persons.Select(x => x.ID);
            foreach (var id in Persons_ID)
            {
                comboBox_Person_Select.Items.Add(id);
            }

            // var items_all = db.Items.Select(x => x.ID);
            // var wearhouses = db.Warehouses.Select(x => x.ID);
            var receits = db.Receipts.Select(x => x.ID);
            foreach (var R in receits)
            {
                comboBox1.Items.Add(R);
            }
            ReceitRefresh(sender,e);
            groupBox2.Enabled = false;
            //Item_receit_Refresh(sender,e);


        }
        private void ReceitRefresh(object sender, EventArgs e)
        {
            groupBox2.Enabled=false;
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = db.Receipts.Select(c => new {Receit_ID = c.ID, c.Wearhouse_ID, Wearhouse_name = c.Warehouse.Name, c.receipt_date, c.Type }).ToList();
            Tbox_Wearhouse.Text = Tbox_ID.Text = "";
           
            radioButton_IN.Checked = radioButton_Out.Checked = false;
        }
        private void Item_receit_Refresh(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            int id = int.Parse(comboBox1.Text);
            dataGridView2.DataSource = db.Items_Receipt.Where(c=>c.Receipt_ID==id).Select(c => new {c.Item_Receipt_ID , Receit_ID = c.Receipt.ID, c.Item_ID , c.Item.Name, c.Person_ID, c.Quantity  , c.P_Date ,c.EX_Date}).ToList();
            Tbox_Item_name.Text = Tbox_Item_Select.Text = Tbox_Person_Name.Text = Tbox_Person_Select.Text = Tbox_Amount.Text = "";
            comboBox_Item_Select.Text="";
            comboBox_Person_Select.Text="";
            var x = db.Items_Receipt.Where(c=>c.Receipt_ID==id).Select(c=>c.Item_Receipt_ID).ToList();
            comboBox_Recit_Item_ID.Items.Clear();
            
            foreach (var xx in x)
            {
                comboBox_Recit_Item_ID.Items.Add(xx);
            }
            comboBox_Recit_Item_ID.Text = "";
            //  comboBox1.Text = "";

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            int id = int.Parse(comboBox1.Text);
            var recipt = db.Receipts.Where(c=>c.ID == id).FirstOrDefault();
            
            Tbox_ID.Text = recipt.ID.ToString();
            Tbox_Wearhouse.Text = recipt.Wearhouse_ID.ToString();
            dateTimePicker_Recipt.Value = recipt.receipt_date;
            if (recipt.Type == true)
            {
                radioButton_IN.Checked = true;
            }
            else if (recipt.Type == false)
            {
                radioButton_Out.Checked = true;
            }

            Item_receit_Refresh(sender, e);

        }

        private void comboBox_Wearhouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Add_Receipt_Click(object sender, EventArgs e)
        {
            if (Tbox_Wearhouse.Text != "" && (radioButton_IN.Checked || radioButton_Out.Checked))
            {
                
                var recipt = new Receipt();

                recipt.Wearhouse_ID = int.Parse(Tbox_Wearhouse.Text);
                recipt.receipt_date = dateTimePicker_Recipt.Value;
                
                if (radioButton_IN.Checked == true)
                {
                    recipt.Type = true;
                   
                }
                else if (radioButton_Out.Checked == true)
                {
                    recipt.Type = false;
                    
                }

                db.Receipts.Add(recipt);
                db.SaveChanges();
                ReceitRefresh(sender , e);
                comboBox1.Items.Add(recipt.ID);
                

                
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("enter value");
            }
        }

        private void Btn_Update_Receipt_Click(object sender, EventArgs e)
        {
            if (Tbox_Wearhouse.Text != "" && (radioButton_IN.Checked || radioButton_Out.Checked))
            {
                int id = int.Parse(comboBox1.Text);
                var recipt = db.Receipts.Find(id);              
                recipt.Wearhouse_ID = int.Parse(Tbox_Wearhouse.Text);
                recipt.receipt_date = dateTimePicker_Recipt.Value;

                if (radioButton_IN.Checked == true)
                {
                    recipt.Type = true;

                }
                else if (radioButton_Out.Checked == true)
                {
                    recipt.Type = false;

                }

                db.Receipts.AddOrUpdate(recipt);
                db.SaveChanges();
                ReceitRefresh(sender, e);
              



                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("enter value");
            }
        }

        private void Btn_Delete_Receipt_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(comboBox_Recit_Item_ID.Text);
            //var result = db.Items_Receipt.Find(id);
            //db.Items_Receipt.Remove(result);
            //db.SaveChanges();
            //Item_receit_Refresh(sender, e);
            //MessageBox.Show("Done");


            int id = int.Parse(Tbox_ID.Text);
            var recipt = db.Receipts.Find(id);
            if (recipt != null)
            {
                var collection = db.Items_Receipt.Where(c=>c.Receipt_ID == id).ToList();
               
                foreach ( var r in collection)
                { 
                    db.Items_Receipt.Remove(r);
                }
                
                db.SaveChanges();
                db.Receipts.Remove(recipt);
                db.SaveChanges();
                ReceitRefresh(sender,e);
                Item_receit_Refresh(sender , e);
                comboBox1.Items.Clear();
                var receits = db.Receipts.Select(x => x.ID);
                foreach (var R in receits)
                {
                    comboBox1.Items.Add(R);
                }
                comboBox1.Text = "";
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Un Avalable");
            }
            
        }

        private void comboBox_Wearhouse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            Tbox_Wearhouse.Text = comboBox_Wearhouse.Text;
        }

        private void comboBox_Item_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tbox_Item_Select.Text = comboBox_Item_Select.Text;
            int id = int.Parse(comboBox_Item_Select.Text);
            var item = db.Items.Find(id);
            Tbox_Item_name.Text = item.Name;

        }

        private void comboBox_Person_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tbox_Person_Select.Text = comboBox_Person_Select.Text;
            int id = int.Parse(comboBox_Person_Select.Text);
            var person = db.Persons.Find(id);
            Tbox_Person_Name.Text = person.Name;
        }

        private void Btn_Add_Item_Click(object sender, EventArgs e)
        {
            if (Tbox_ID.Text !=""&&Tbox_Item_Select.Text !="" && Tbox_Person_Select.Text!="" && Tbox_Amount.Text!="")
            {
                Items_Receipt items_Receipt = new Items_Receipt();
                items_Receipt.Receipt_ID = int.Parse(Tbox_ID.Text);
                items_Receipt.Item_ID = int.Parse(Tbox_Item_Select.Text);
                items_Receipt.Person_ID = int.Parse(Tbox_Person_Select.Text);
                items_Receipt.Quantity = int.Parse(Tbox_Amount.Text);
                items_Receipt.P_Date = dateTimePicker_PDate.Value;
                items_Receipt.EX_Date = dateTimePicker_ExDate.Value;
                db.Items_Receipt.Add(items_Receipt);
                db.SaveChanges();
                Item_receit_Refresh(sender , e);
                MessageBox.Show("Added");
                
            }
            else
            {
                MessageBox.Show("enter value");
            }
            
        }

        private void Btn_Delete_Item_Click(object sender, EventArgs e)
        {
            if (comboBox_Recit_Item_ID.Text!="")
            {
                int id = int.Parse(comboBox_Recit_Item_ID.Text);
                var result =  db.Items_Receipt.Find(id);
                db.Items_Receipt.Remove(result);
                db.SaveChanges() ;
                Item_receit_Refresh(sender, e);
                MessageBox.Show("Done");

            }
            else
            {
                MessageBox.Show("Enter Value");
            }
        }

        private void comboBox_Recit_Item_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Recit_Item_ID.Text);
            var result = db.Items_Receipt.Find(id);
            Tbox_Item_Select.Text = result.Item_ID.ToString();
            Tbox_Item_name.Text = result.Item.Name;
            Tbox_Person_Select.Text = result.Person_ID.ToString();
            Tbox_Person_Name.Text = result.Person.Name;
            Tbox_Amount.Text = result.Quantity.ToString();
            dateTimePicker_PDate.Value = result.P_Date;
            dateTimePicker_ExDate.Value = result.EX_Date;
           
        }

        private void Btn_Update_Item_Click(object sender, EventArgs e)
        {
            if (Tbox_ID.Text != "" && Tbox_Item_Select.Text != "" && Tbox_Person_Select.Text != "" && Tbox_Amount.Text != "")
            {
                int id = int.Parse(comboBox_Recit_Item_ID.Text);
                var result = db.Items_Receipt.Find(id);
                result.Receipt_ID = int.Parse(Tbox_ID.Text);
                result.Item_ID = int.Parse(Tbox_Item_Select.Text);
                result.Person_ID = int.Parse(Tbox_Person_Select.Text);
                result.Quantity = int.Parse(Tbox_Amount.Text);
                result.P_Date = dateTimePicker_PDate.Value;
                result.EX_Date = dateTimePicker_ExDate.Value;
                db.Items_Receipt.AddOrUpdate(result);
                db.SaveChanges();
                Item_receit_Refresh(sender, e);
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Enter value");
            }
        }
    }
}
