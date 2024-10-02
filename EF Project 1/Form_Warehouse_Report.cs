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
    public partial class Form_Warehouse_Report : Form
    {
        public Form_Warehouse_Report()
        {
            InitializeComponent();
        }
        EF_Model db;
        private void Form_Warehouse_Report_Load(object sender, EventArgs e)
        {
            db = new EF_Model();
            var Warehouses = db.Warehouses.Select(c=>c);
            foreach(var warehouse in Warehouses)
            {
                comboBox_Wearhouse.Items.Add(warehouse.ID);
            }

        }

        private void comboBox_Wearhouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox_Wearhouse.Text);
            var result = db.Warehouses.Find(id);
            Tbox_Wearhouse_Id.Text = result.ID.ToString();
            Tbox_Wearhouse_Name.Text = result.Name;

        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Tbox_Wearhouse_Id.Text);
            var start = dateTimePicker_Start_Date.Value;
            var end = dateTimePicker_End_Date.Value;
           var result = db.Receipts.Where(c=>c.Wearhouse_ID==id && c.receipt_date>start && c.receipt_date<=end).Select(c=>c).ToList();
            dataGridView1.DataSource = result;
        }
    }
}
