using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project_1
{
    public partial class Form_Wearhouse : Form
    {
        EF_Model db;
        public Form_Wearhouse()
        {
            InitializeComponent();
        }

        private void Form_Wearhouse_Load(object sender, EventArgs e)
        {
            db = new EF_Model();
            var items = db.Warehouses.Select(x => x.ID);
            foreach (var item in items)
            {
                comboBox1.Items.Add(item);
            }
            Btn_Display_Click(sender , e);
            
        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = db.Warehouses.Select(c => new {c.ID, c.Name, c.Address, c.Supervisor }).ToList(); //.Local ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);
            var w = db.Warehouses.Where(c => c.ID == id).Select(c=>c).FirstOrDefault();

            Tbox_ID.Text = w.ID.ToString();
            Tbox_name.Text = w.Name;
            Tbox_Address.Text = w.Address;
            Tbox_Supervisor.Text = w.Supervisor;
            
            
           
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Tbox_name.Text != "" && Tbox_Address.Text != "" && Tbox_Supervisor.Text != "")
            {
                Warehouse w = new Warehouse();
                w.Name = Tbox_name.Text;
                w.Address = Tbox_Address.Text;
                w.Supervisor = Tbox_Supervisor.Text;
                db.Warehouses.Add(w);
                db.SaveChanges();
                Btn_Display_Click(sender, e);
                comboBox1.Items.Add(w.ID);
                Tbox_Address.Text = Tbox_ID.Text = Tbox_name.Text = Tbox_Supervisor.Text = "";
                Btn_Display_Click(sender, e);
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("enter value");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Tbox_ID.Text != "")
            {
                if (Tbox_name.Text != "" && Tbox_Address.Text != "" && Tbox_Supervisor.Text != "")
                {
                    Warehouse w = new Warehouse();
                    w.ID = int.Parse(Tbox_ID.Text);
                    w.Name = Tbox_name.Text;
                    w.Address = Tbox_Address.Text;
                    w.Supervisor = Tbox_Supervisor.Text;
                    db.Warehouses.AddOrUpdate(w);
                    db.SaveChanges();
                    //Refresh();
                    // comboBox1.Items.Clear();

                    Tbox_Address.Text = Tbox_ID.Text = Tbox_name.Text = Tbox_Supervisor.Text = "";
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
        private void Refresh(object sender ,EventArgs e)
        {
            comboBox1.Items.Clear();

            Tbox_Address.Text = Tbox_ID.Text = Tbox_name.Text = Tbox_Supervisor.Text = "";
            Btn_Display_Click(sender, e);

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Tbox_ID.Text != "")
            {

                int Id = int.Parse(Tbox_ID.Text);
            Warehouse w = db.Warehouses.Find(Id);
            if (w != null)
            {
                db.Warehouses.Remove(w);
                db.SaveChanges();
                Tbox_Address.Text = Tbox_ID.Text = Tbox_name.Text = Tbox_Supervisor.Text = "";
                Btn_Display_Click(sender, e);
                comboBox1 .Items.Remove(Id);
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
    }
}
