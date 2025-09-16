using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_restaurant_menu_system
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            for (int i = 0; i <= 100; i++)
            {
                bool isSlected = false;

                if (i % 3 == 0) { isSlected = true; }
                AddSquare("fldBox", $"Bàn {i}", isSlected);
            }

        }
        private void AddSquare(string targetPanelName, string squareName, bool selected)
        {
            // tìm FlowLayoutPanel theo Name trong Form
            FlowLayoutPanel target = this.Controls
                .OfType<FlowLayoutPanel>()
                .FirstOrDefault(f => f.Name == targetPanelName);
            target.AutoScroll = true;
            if (target != null)
            {

                Panel square = new Panel();
                square.Width = 80;
                square.Height = 80;
                if (selected)
                {
                    square.BackColor = Color.Green;
                }
                else
                {
                    square.BackColor = Color.DarkGray;
                }
                square.Margin = new Padding(5);
                square.Name = squareName;




                Label lbl = new Label();
                lbl.Text = squareName;
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                square.Controls.Add(lbl);
                lbl.ForeColor = Color.White;
                lbl.Font = new Font(lbl.Font, FontStyle.Bold);

                target.Controls.Add(square);

                square.Click += Square_Click;
                lbl.Click += Square_click;

            }
            else
            {
                MessageBox.Show("Không tìm thấy FlowLayoutPanel có name = " + targetPanelName);
            }
        }

        private void Square_click(object sender, EventArgs e)
        {
            FormChiTiet form = new FormChiTiet(this.Location);
            form.Show();
            this.Hide();
            

        }

        private void Square_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void cbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void fldBox_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
