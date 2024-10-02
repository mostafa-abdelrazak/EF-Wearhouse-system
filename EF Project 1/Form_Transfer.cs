using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project_1
{
    public partial class Form_Transfer : Form
    {

        public Form_Transfer()
        {
            InitializeComponent();
        }
        EF_Model db;

        private void Form_Transfer_Load(object sender, EventArgs e)
        {
            db = new EF_Model();
            
            var Wearhouses = db.Warehouses.Select(x => x);
            foreach (var Wearhouse in Wearhouses)
            {
                comboBox_IN_Wearhouse.Items.Add(Wearhouse.ID);
                comboBox_Out_Wearhouse.Items.Add(Wearhouse.ID);

            }

            var Items = db.Items.Select(x => x);
            foreach (var item in Items)
            {
                comboBox_Item.Items.Add(item.ID);

            }

            var Suppliers = db.Persons.Select(x => x);
            foreach (var Supplier in Suppliers)
            {
                comboBox_Supplier.Items.Add(Supplier.ID);

            }
        }

        private void PRefresh(object sender, EventArgs e)
        {
            comboBox_Supplier.Text = "";
            comboBox_Out_Wearhouse.Text = "";
            comboBox_IN_Wearhouse.Text = "";
            comboBox_Item.Text = "";
            Tbox_Amount.Text = Tbox_IN_Wearhouse_ID.Text = Tbox_IN_Wearhouse_Name.Text = Tbox_Item_ID.Text = Tbox_Item_Name.Text = Tbox_Out_Wearhouse_Id.Text = Tbox_Out_Wearhouse_Name.Text = Tbox_Supplier_ID.Text = Tbox_Supplier_Name.Text = "";

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Tbox_Person_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbox_Item_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbox_Item_Select_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbox_Person_Select_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Person_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_IN_Wearhouse.Text);
            var item = db.Warehouses.Find(id);
            Tbox_IN_Wearhouse_ID.Text = item.ID.ToString();
            Tbox_IN_Wearhouse_Name.Text = item.Name;
        }

        private void comboBox_Recit_Item_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Item_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Out_Wearhouse.Text);
            var item = db.Warehouses.Find(id);
            Tbox_Out_Wearhouse_Id.Text = item.ID.ToString();
            Tbox_Out_Wearhouse_Name.Text = item.Name;
            
        }

        private void comboBox_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse( comboBox_Item.Text);
            var item = db.Items.Find(id);
            Tbox_Item_ID.Text = item.ID.ToString();
            Tbox_Item_Name.Text = item.Name;
        }

        private void comboBox_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Supplier.Text);
            var item = db.Persons.Find(id);
            Tbox_Supplier_ID.Text = item.ID.ToString();
            Tbox_Supplier_Name.Text = item.Name.ToString();
        }

        private void Btn_Transfer_Click(object sender, EventArgs e)
        {

            if (Tbox_Supplier_ID.Text !="" && Tbox_Out_Wearhouse_Id.Text != "" && Tbox_Amount.Text !="" && Tbox_IN_Wearhouse_ID.Text !="" && Tbox_Item_ID.Text !="")
            {
                Receipt receiptOut = new Receipt();
                Receipt receiptIn = new Receipt();
                receiptOut.receipt_date = DateTime.Now;
                receiptIn.receipt_date = DateTime.Now;
                receiptOut.Wearhouse_ID = int.Parse(Tbox_Out_Wearhouse_Id.Text);
                receiptIn.Wearhouse_ID = int.Parse(Tbox_IN_Wearhouse_ID.Text);
                receiptOut.Type = true;
                receiptIn.Type = false;
                var Out = db.Receipts.Add(receiptOut);
                db.SaveChanges();
                var In = db.Receipts.Add(receiptIn);
                db.SaveChanges();
                
                Items_Receipt items_Receipt_out = new Items_Receipt();
                Items_Receipt items_Receipt_in = new Items_Receipt();

                items_Receipt_out.Receipt_ID = Out.ID;
                items_Receipt_in.Receipt_ID = In.ID;

                items_Receipt_out.Item_ID = int.Parse(Tbox_Item_ID.Text);
                items_Receipt_in.Item_ID = int.Parse(Tbox_Item_ID.Text);

                items_Receipt_out.Quantity = int.Parse(Tbox_Amount.Text);
                items_Receipt_in.Quantity = int.Parse(Tbox_Amount.Text);

                items_Receipt_out.Person_ID = int.Parse(Tbox_Supplier_ID.Text);
                items_Receipt_in.Person_ID = int.Parse(Tbox_Supplier_ID.Text);

                items_Receipt_out.P_Date = dateTimePicker_PDate.Value;
                items_Receipt_in.P_Date = dateTimePicker_PDate.Value;

                items_Receipt_out.EX_Date = dateTimePicker_ExDate.Value;
                items_Receipt_in.EX_Date = dateTimePicker_ExDate.Value;

                db.Items_Receipt.Add(items_Receipt_out);
                db.Items_Receipt.Add(items_Receipt_in);
                
                db.SaveChanges();

                PRefresh(sender, e);
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("Enter Value");
            }
        }
    }
}
