using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.CustomUI
{
    public partial class BulkContactAddControl : UserControl
    {

        public int NoOfFields
        {
            get
            {
                return (int)this.UpDownNoOfFields.Value;
            }
        }

        public BulkContactAddControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
