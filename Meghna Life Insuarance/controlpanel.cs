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
    public partial class controlpanel : Form
    {
        public controlpanel()
        {
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.Close();
            Class1 c1 = new Class1();
            string custom = c1.getcustomer();
            
                panel3.Controls.Add(userstatus.ins);
                userstatus.ins.Dock = DockStyle.Fill;
                userstatus.ins.BringToFront();

            
            
            
        }

        public void controlpanel_Load(object sender, EventArgs e)
        {
          
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //status
            panel3.Controls.Add(userstatus.ins);
            userstatus.ins.Dock = DockStyle.Fill;
            userstatus.ins.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //payment
            panel3.Controls.Add(userpayment.ins);
            userpayment.ins.Dock = DockStyle.Fill;
            userpayment.ins.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //complainbox
            panel3.Controls.Add(usercomplain.ins);
            usercomplain.ins.Dock = DockStyle.Fill;
            usercomplain.ins.BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
