using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace EF_Project_1
{
    public partial class Form_Items_Report : Form
    {
        EF_Model db = new EF_Model();
        public Form_Items_Report()
        {
            InitializeComponent();
            var x  = db.Warehouses.Select(c => c.Name).ToList();
           
            // int[]b = new int[x.Count];
            foreach (var item in x)
            {
                checkedListBox1.Items.Add(item);

            }   
                //(new {Text = item.Text.ToString() , item.Value });            }
          //  checkedListBox1.DataSource = x; 
                
          //  checkedListBox1.DisplayMember = nameof(Warehouse.Name);
          //  checkedListBox1.ValueMember = nameof(Warehouse.ID);
            
        }

        private void Form_Items_Report_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Warehouse> w = new List<Warehouse>();
            var x = db.Warehouses.Select(c => c).ToList();
            
            foreach (int itemChecked in checkedListBox1.CheckedIndices)// .SelectedValue ) //.CheckedItems)
            {
                w.Add(x[itemChecked-1]);
              
            }
            
             //   if (itemChecked is Warehouse store) Ids.Add(store.ID);
            //  .Where(x => StoreIDs.Contains(x.StoreID))
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
