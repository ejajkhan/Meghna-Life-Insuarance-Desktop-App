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
    public partial class userpayment : UserControl
    {
        private static userpayment _ins;
        public static userpayment ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new userpayment();
                }
                return _ins;
            }

        }
        public userpayment()
        {
            InitializeComponent();
        }

        private void userpayment_Load(object sender, EventArgs e)
        {

        }
    }
}
