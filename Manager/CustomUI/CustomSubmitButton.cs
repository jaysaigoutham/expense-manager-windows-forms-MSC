using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager.CustomUI
{
    public class CustomSubmitButton : Button
    {
        public CustomSubmitButton()
        {
            this.Size = new System.Drawing.Size(200, 60);
            this.TabIndex = 0;
            this.Text = "Submit Bulk";
            this.UseVisualStyleBackColor = true;
            this.BackColor = Color.LightGray;

        }
    }
}
