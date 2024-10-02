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
    public partial class Form_Time_Period_Report : Form
    {
        public Form_Time_Period_Report()
        {
            InitializeComponent();
        }
         EF_Model db = new EF_Model();
        private void Form_Time_Period_Report_Load(object sender, EventArgs e)
        {
            comboBox_Hours.Text = "0";
            comboBox_Minutes.Text = "0";
            combo_Days.Text = "0";
            combo_months.Text = "0";
            combo_Years.Text = "0";
            int i = 0;
            while (i != 24)
            {
                comboBox_Hours.Items.Add(i);
                i++;
            }
            i = 0;
            while (i != 60)
            {
                comboBox_Minutes.Items.Add(i);
                i++;
            }
            i = 0;
            while (i != 30)
            {
                combo_Days.Items.Add(i);
                i++;
            }
            i = 0;
            while (i != 12)
            {
                combo_months.Items.Add(i);
                i++;
            }
            i = 0;
            while (i != 100)
            {
                combo_Years.Items.Add(i);
                i++;
            }
            


        }

        private void comboBox_Hours_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Dispaly_Click(object sender, EventArgs e)
        {
            int hours = int.Parse(comboBox_Hours.Text);
            int minutes = int.Parse(comboBox_Minutes.Text);
            int days = int.Parse(combo_Days.Text);
            int months = int.Parse(combo_months.Text);
            int years = int.Parse(combo_Years.Text);
          //  DateTime dateTimeNow = DateTime.Now;
            DateTime SelectedDate = new DateTime(DateTime.Now.Year-years, DateTime.Now.Month - months, DateTime.Now.Day - days, DateTime.Now.Hour - hours, DateTime.Now.Minute - minutes,0);
             
           // TimeSpan SelectedDate = dateTimeNow.Subtract(SelectedSpan);
            
            var result = db.Receipts.Where(c=>(c.receipt_date > SelectedDate)&&c.Type==true)
                .Select(c=>  new {c.Warehouse.Name ,c.receipt_date, x = c.Items_Receipt.Select(v=>new {v.Item_ID,v.Item.Name,v.Receipt_ID,v.Quantity,v.P_Date,v.EX_Date,Supplier =v.Person.Name}).ToList() }).ToList();
            
            List<object> list = new List<object>();
            foreach (var item in result)
            {
                foreach (var item2 in item.x)
                {
                    list.Add(new {wearhouse = item.Name,item.receipt_date,item2.Item_ID,item =item2.Name ,item2.Receipt_ID ,item2.Quantity ,item2.P_Date ,item2.EX_Date,item2.Supplier });
                }

                 
            }
            dataGridView1.DataSource = list;



        }
    }
}
