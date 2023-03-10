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
    public partial class usercomplain : UserControl
    {
        private static usercomplain _ins;
        public static usercomplain ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new usercomplain();
                }
                return _ins;
            }

        }
        public usercomplain()
        {
            InitializeComponent();
        }

        private void usercomplain_Load(object sender, EventArgs e)
        {

        }
    }
}
