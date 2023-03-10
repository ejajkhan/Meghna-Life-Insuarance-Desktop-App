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
    public partial class adminadmin : UserControl
    {
        private static adminadmin _ins;
        public static adminadmin ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new adminadmin();
                }
                return _ins;
            }

        }
        public adminadmin()
        {
            InitializeComponent();
        }

        private void adminadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
