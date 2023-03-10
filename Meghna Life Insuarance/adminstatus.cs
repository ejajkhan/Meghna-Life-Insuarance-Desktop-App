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
    public partial class adminstatus : UserControl
    {
        private static adminstatus _ins;
        public static adminstatus ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new adminstatus();
                }
                return _ins;
            }

        }
        public adminstatus()
        {
            InitializeComponent();
        }

        private void adminstatus_Load(object sender, EventArgs e)
        {

        }
    }
}
