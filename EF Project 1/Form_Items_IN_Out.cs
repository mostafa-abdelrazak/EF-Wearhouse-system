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
    public partial class Form_Items_IN_Out : Form
    {
        public Form_Items_IN_Out()
        {
            InitializeComponent();
        }
        EF_Model db = new EF_Model();
        private void Form_Items_IN_Out_Load(object sender, EventArgs e)
        {
            
            var Warehouses = db.Warehouses.Select(c => c);
            foreach (var warehouse in Warehouses)
            {
                comboBox_Wearhouse.Items.Add(warehouse.ID);
                checkedListBox1.Items.Add(warehouse.Name);
            }



          //  checkedListBox1.DataSource = db.Warehouses.ToList();
           // checkedListBox1.DisplayMember = nameof(Warehouse.Name);
           // checkedListBox1.ValueMember = nameof(Warehouse.ID);
        }

        private void comboBox_Wearhouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Wearhouse.Text);
            var result = db.Warehouses.Find(id);
        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Wearhouse.Text);
            var start = dateTimePicker_Start_Date.Value;
            var end = dateTimePicker_End_Date.Value;
           // var result = db.Receipts.Where(c => c.Wearhouse_ID == id && c.receipt_date > start && c.receipt_date <= end).Select(c => c).ToList();
           // dataGridView1.DataSource = result;



            var result = db.Receipts.Where(c => (c.Wearhouse_ID == id) && c.receipt_date > start && c.receipt_date <= end)
               .Select(c => new {c.Type , c.Warehouse.Name, c.receipt_date, x = c.Items_Receipt.Select(v => new { v.Item_ID, v.Item.Name, v.Receipt_ID, v.Quantity, v.P_Date, v.EX_Date, Supplier = v.Person.Name }).ToList() }).ToList();

            List<object> list = new List<object>();
            foreach (var item in result)
            {
                foreach (var item2 in item.x)
                {
                    list.Add(new {item.Type, wearhouse = item.Name, item.receipt_date, item2.Item_ID, item = item2.Name, item2.Receipt_ID, item2.Quantity, item2.P_Date, item2.EX_Date, item2.Supplier });
                }


            }
            dataGridView1.DataSource = list;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
