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
    public partial class adminpayment : UserControl
    {
        private static adminpayment _ins;
        public static adminpayment ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new adminpayment();
                }
                return _ins;
            }

        }
        public adminpayment()
        {
            InitializeComponent();
        }

        private void adminpayment_Load(object sender, EventArgs e)
        {

        }
    }
}
