using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meghna_Life_Insuarance
{
    public partial class adcontrol : Form
    {
        public adcontrol()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.Close();
            

            panel3.Controls.Add(adminstatus.ins);
            adminstatus.ins.Dock = DockStyle.Fill;
            adminstatus.ins.BringToFront();
        }

        private void adcontrol_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //adminstatus
            panel3.Controls.Add(adminstatus.ins);
            adminstatus.ins.Dock = DockStyle.Fill;
            adminstatus.ins.BringToFront();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //customer payment
            panel3.Controls.Add(adminpayment.ins);
            adminpayment.ins.Dock = DockStyle.Fill;
            adminpayment.ins.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //add customer
            panel3.Controls.Add(adminadd.ins);
            adminadd.ins.Dock = DockStyle.Fill;
            adminadd.ins.BringToFront();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //updatecustomer
            panel3.Controls.Add(adminupdate.ins);
            adminupdate.ins.Dock = DockStyle.Fill;
            adminupdate.ins.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //add admin
            panel3.Controls.Add(adminadmin.ins);
            adminadmin.ins.Dock = DockStyle.Fill;
            adminadmin.ins.BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //logout
            this.Close();
        }
    }
}
