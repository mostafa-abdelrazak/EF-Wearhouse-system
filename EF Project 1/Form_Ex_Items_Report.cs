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
    public partial class Form_Ex_Items_Report : Form
    {
        public Form_Ex_Items_Report()
        {
            InitializeComponent();
        }
        EF_Model db = new EF_Model();
        private void Form_Ex_Items_Report_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Dispaly_Click(object sender, EventArgs e)
        {
            var Selected_Date = dateTimePicker1.Value;
            //var result = db.Items_Receipt.Where(c => c.EX_Date > Selected_Date).Select(c => c).ToList();
            var result = db.Items_Receipt.Where(c => c.EX_Date > Selected_Date)
                .Select(c => new {Item_Name = c.Item.Name,c.Item_ID,c.Item_Receipt_ID,c.Quantity,Suppier_Name =c.Person.Name,c.P_Date,c.EX_Date}).ToList();
            dataGridView1.DataSource = result;
            // int i = dateTimePicker1.Value.Month;
            //int q = dateTimePicker1.Value.Hour;
            //int z = dateTimePicker1.Value.Year;

        }
    }
}
