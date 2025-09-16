using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_restaurant_menu_system
{
    public partial class FormChiTiet : Form
    {
        public FormChiTiet(Point location)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = location;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void mQuayLai_Click(object sender, EventArgs e)
        {
            FormChinh form = new FormChinh();
            form.Show();
            this.Close();
        }
    }
}
