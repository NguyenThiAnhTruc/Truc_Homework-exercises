using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTrang57
{
    public partial class Button : Form
    {
        public Button()
        {
            InitializeComponent();
        }

        private void ckbMauChu_CheckedChanged(object sender, EventArgs e)
        {
            if(this.ckbMauChu.Checked) 
                this.btnButton.ForeColor= Color.Red;
            else
                this.btnButton.ForeColor= Color.Black;
        }

        private void cknMauNen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cknMauNen.Checked)

                this.btnButton.BackColor = Color.LightCyan;
            else
                this.btnButton.BackColor = this.btnButtonFlat.BackColor;
            
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
                this.btnButtonFlat.FlatStyle = FlatStyle.Flat;
            else
                this.btnButtonFlat.FlatStyle = FlatStyle.Popup;
        }
    }
}
