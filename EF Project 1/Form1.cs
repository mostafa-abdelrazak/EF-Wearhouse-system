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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Warhouse_Click(object sender, EventArgs e)
        {

            Form_Wearhouse w_form = new Form_Wearhouse();

                w_form.ShowDialog();
            
        }

        private void Btn_Item_Click(object sender, EventArgs e)
        {
            Form_Item I_form = new Form_Item();

            I_form.ShowDialog();
        }

        private void Btn_Person_Click(object sender, EventArgs e)
        {
            Form_Person P_form = new Form_Person();

            P_form.ShowDialog();
        }

        private void Btn_Receipt_Click(object sender, EventArgs e)
        {
            Form_Receipt R_form = new Form_Receipt();

            R_form.ShowDialog();
        }

        private void Btn_Transfer_Click(object sender, EventArgs e)
        {
            Form_Transfer T_form = new Form_Transfer();
            T_form.ShowDialog();
        }

        private void Btn_Warehouse_Report_Click(object sender, EventArgs e)
        {
            Form_Warehouse_Report W_R = new Form_Warehouse_Report();
            W_R.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Items_Report I_R  = new Form_Items_Report();
            I_R.ShowDialog();
        }

        private void Btn_Ex_Items_Report_Click(object sender, EventArgs e)
        {
            Form_Ex_Items_Report E_X_I = new Form_Ex_Items_Report();
            E_X_I.ShowDialog();
        }

        private void Btn_Time_period_report_Click(object sender, EventArgs e)
        {
            Form_Time_Period_Report form_Time_Period_Report = new Form_Time_Period_Report();
            form_Time_Period_Report.ShowDialog();
        }

        private void Btn_Item_IN_Out_Click(object sender, EventArgs e)
        {
            Form_Items_IN_Out form_Items_IN_Out = new Form_Items_IN_Out();
            form_Items_IN_Out.ShowDialog();
        }
    }
}
