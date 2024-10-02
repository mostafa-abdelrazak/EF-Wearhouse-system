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
    public partial class Form_Item : Form
    {
        public Form_Item()
        {
            InitializeComponent();
        }
        EF_Model db;
        private void Form_Item_Load(object sender, EventArgs e)
        {

            db = new EF_Model();
            var items = db.Items.Select(x => x.ID);
            foreach (var item in items)
            {
                comboBox1.Items.Add(item);
            }
            Btn_Display_Click(sender, e);
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Tbox_name.Text != "" && Tbox_Unit.Text != "")
            {
                Item i = new Item();
                i.Name = Tbox_name.Text;
                i.Unit = int.Parse(Tbox_Unit.Text);

                db.Items.Add(i);
                db.SaveChanges();
                Btn_Display_Click(sender, e);
                comboBox1.Items.Add(i.ID);
                Tbox_Unit.Text = Tbox_ID.Text = Tbox_name.Text = "";
                Btn_Display_Click(sender, e);
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("enter value");
            }
            
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Tbox_ID.Text != "")
            {
                if (Tbox_name.Text != "" && Tbox_Unit.Text != "")
                {
                    Item i = new Item();
                    i.ID = int.Parse(Tbox_ID.Text);
                    i.Name = Tbox_name.Text;
                    i.Unit = int.Parse(Tbox_Unit.Text);

                    db.Items.AddOrUpdate(i);
                    db.SaveChanges();
                    //Refresh();
                    // comboBox1.Items.Clear();

                    Tbox_Unit.Text = Tbox_ID.Text = Tbox_name.Text = "";
                    Btn_Display_Click(sender, e);
                    MessageBox.Show("updated");
                }
                else
                {
                    MessageBox.Show("Enter Value");
                }
            }
            else
            {
                MessageBox.Show("Select Item");
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            if (Tbox_ID.Text != "")
            {
                int Id = int.Parse(Tbox_ID.Text);
                Item i = db.Items.Find(Id);
                if (i != null)
                {
                    db.Items.Remove(i);
                    db.SaveChanges();
                    Tbox_Unit.Text = Tbox_ID.Text = Tbox_name.Text = "";
                    Btn_Display_Click(sender, e);
                    comboBox1.Items.Remove(Id);
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Not Avalable");
                }
            }
            else
            {
                MessageBox.Show("Select Item");
            }


        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = db.Items.Select(c => new { c.ID, c.Name, c.Unit}).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);
            var i = db.Items.Where(c => c.ID == id).Select(c => c).FirstOrDefault();

            Tbox_ID.Text = i.ID.ToString();
            Tbox_name.Text = i.Name;
            Tbox_Unit.Text = i.Unit.ToString();
            
        }
    }
}
