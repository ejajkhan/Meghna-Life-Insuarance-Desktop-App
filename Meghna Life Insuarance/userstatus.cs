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
    public partial class userstatus : UserControl
    {
        private static userstatus _ins;
        public static userstatus ins
        {
            get
            {
                if (_ins == null)
                {
                    _ins = new userstatus();
                }
                return _ins;
            }

        }
        public userstatus()
        {
            InitializeComponent();
        }

        private void userstatus_Load(object sender, EventArgs e)
        {

        }
    }
}
