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
    public partial class adminpanel : UserControl
    {
        private static adminpanel _ins;
        public static adminpanel ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new adminpanel();
                }
                return _ins;
            }

        }
        public adminpanel()
        {
            InitializeComponent();
        }

        private void adminpanel_Load(object sender, EventArgs e)
        {

        }
    }
}
