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
    public partial class adminadd : UserControl
    {
        private static adminadd _ins;
        public static adminadd ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new adminadd();
                }
                return _ins;
            }

        }
        public adminadd()
        {
            InitializeComponent();
        }

        private void adminadd_Load(object sender, EventArgs e)
        {

        }
    }
}
