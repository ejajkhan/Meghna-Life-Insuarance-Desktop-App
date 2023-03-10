using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meghna_Life_Insuarance
{
    public partial class login : UserControl
    {
        public string customer;
        private static login _ins;
        public static login  ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new login();
                }
                return _ins;
            }
        
        }
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string div = comboBox2.Text;
            string dis = comboBox1.Text;
            string name = textBox1.Text;
            string pass = textBox2.Text;


            if(checkBox1.Checked==false && checkBox2.Checked==false)
            {
                MessageBox.Show("Please tick Your Identity as User or Admin");
            }

            else if(div==null || dis==null|| name==null||pass==null)
            {
                MessageBox.Show("Fill all the boxes Properly");
            }

            else
            {
                Class1 c1 = new Class1();
                c1.thecustomer(customer);
               this.Hide();
                if(customer=="user")
                {
                   controlpanel cp = new controlpanel();
                   cp.Show();
                }
                else if(customer=="admin")
                {
                    adcontrol ac = new adcontrol();
                    ac.Show();
                }
               
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBox2.Checked = false;
            customer = "user";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBox1.Checked = false;
            customer = "admin";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
