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
    public partial class Form_Person : Form
    {
        public Form_Person()
        {
            InitializeComponent();
        }
        EF_Model db;
        private void Form_Person_Load(object sender, EventArgs e)
        {

            db = new EF_Model();
            var Persons = db.Persons.Select(x => x.ID);
            foreach (var Person in Persons)
            {
                comboBox1.Items.Add(Person);
            }
            Btn_Display_Click(sender, e);
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Tbox_name.Text != "" && Tbox_Phone.Text != "" && Tbox_Fax.Text != "" && Tbox_Email.Text != "" && Tbox_Mobile.Text != "" && Tbox_Website.Text != "" && ( radio_Client.Checked || radio_Supplier.Checked))
            {
                Person P = new Person();
                P.Name = Tbox_name.Text;
                P.phone = int.Parse(Tbox_Phone.Text);
                P.fax = int.Parse(Tbox_Fax.Text);
                P.mobile = int.Parse(Tbox_Mobile.Text);
                P.Email = Tbox_Email.Text;
                P.website = Tbox_Website.Text;
                if (radio_Supplier.Checked)
                {
                    P.Type = true;
                }
                else if(radio_Client.Checked)
                {
                    P.Type= false;
                }


                db.Persons.Add(P);
                db.SaveChanges();
                Btn_Display_Click(sender, e);
                comboBox1.Items.Add(P.ID);
                Tbox_Email.Text = Tbox_ID.Text = Tbox_name.Text = Tbox_Fax.Text = Tbox_Phone.Text = Tbox_Mobile.Text = Tbox_Website.Text =  "";
                radio_Client.Checked = radio_Supplier.Checked = false;
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
                if (Tbox_name.Text != "" && Tbox_Phone.Text != "" && Tbox_Fax.Text != "" && Tbox_Email.Text != "" && Tbox_Mobile.Text != "" && Tbox_Website.Text != "" && (radio_Client.Checked || radio_Supplier.Checked))
                {
                    Person P = new Person();
                    P.ID = int.Parse(Tbox_ID.Text);
                    P.Name = Tbox_name.Text;
                    P.phone = int.Parse(Tbox_Phone.Text);
                    P.fax = int.Parse(Tbox_Fax.Text);
                    P.mobile = int.Parse(Tbox_Mobile.Text);
                    P.Email = Tbox_Email.Text;
                    P.website = Tbox_Website.Text;
                    if (radio_Supplier.Checked)
                    {
                        P.Type = true;
                    }
                    else if (radio_Client.Checked)
                    {
                        P.Type = false;
                    }

                    db.Persons.AddOrUpdate(P);
                    db.SaveChanges();
                    //Refresh();
                    // comboBox1.Items.Clear();

                    Tbox_Email.Text = Tbox_ID.Text = Tbox_name.Text = Tbox_Fax.Text = Tbox_Phone.Text = Tbox_Mobile.Text = Tbox_Website.Text = "";
                    radio_Client.Checked = radio_Supplier.Checked = false;
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
                Person P = db.Persons.Find(Id);
                if (P != null)
                {
                    db.Persons.Remove(P);
                    db.SaveChanges();
                    Tbox_Email.Text = Tbox_ID.Text = Tbox_name.Text = Tbox_Fax.Text = Tbox_Phone.Text = Tbox_Mobile.Text = Tbox_Website.Text = "";
                    radio_Client.Checked = radio_Supplier.Checked = false;
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
            dataGridView1.DataSource = db.Persons.Select(c => new { c.ID, c.Name, c.phone, c.fax,c.mobile, c.Email, c.website, c.Type}).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.Text);
            var P = db.Persons.Where(c => c.ID == id).Select(c => c).FirstOrDefault();



            Tbox_ID.Text = id.ToString();
            Tbox_name.Text = P.Name;
            Tbox_Phone.Text = P.phone.ToString() ;
            Tbox_Fax.Text = P.fax.ToString() ;
            Tbox_Mobile.Text = P.mobile.ToString() ;
            Tbox_Email.Text =  P.Email ;
            Tbox_Website.Text = P.website ;
            if (P.Type == true)
            {
                radio_Supplier.Checked = true ;
            }
            else if (P.Type == false)
            {
                radio_Client.Checked = true ;
            }

        }

        private void Form_Person_Load_1(object sender, EventArgs e)
        {
            db = new EF_Model();
            var Persons = db.Persons.Select(x => x.ID);
            foreach (var Person in Persons)
            {
                comboBox1.Items.Add(Person);
            }
            Btn_Display_Click(sender, e);
        }
    }
}
