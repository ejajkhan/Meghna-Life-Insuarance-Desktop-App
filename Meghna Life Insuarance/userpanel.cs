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
    public partial class userpanel : UserControl
    {
        controlpanel c1 = new controlpanel();
        private static userpanel _ins;
        public static userpanel ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new userpanel();
                }
                return _ins;
            }

        }
        public userpanel()
        {
            InitializeComponent();
        }


        private void userpanel_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            //status
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //payment
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //complain
        }
    }
}
