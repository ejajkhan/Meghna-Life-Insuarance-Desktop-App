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
    public partial class adminupdate : UserControl
    {
        private static adminupdate _ins;
        public static adminupdate ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new adminupdate();
                }
                return _ins;
            }

        }
        public adminupdate()
        {
            InitializeComponent();
        }

        private void adminupdate_Load(object sender, EventArgs e)
        {

        }
    }
}
