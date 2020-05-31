using Grabar.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Grabar
{
    public partial class Grabar : Form
    {
        public Grabar()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.ResizeRedraw = true;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IconHeadName_Click(object sender, EventArgs e)
        {

        }

        private void MainWindowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonThree_Click(object sender, EventArgs e)
        {
            GrabarControl control = new GrabarControl();
            control.Show();
        }

        private void SideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            ViewForm View = new ViewForm();
            View.Show();
        }

        private void ButtonTwo_Click(object sender, EventArgs e)
        {
            EntryForm Entry = new EntryForm();
            Entry.Show();

        }
        Point lastPoint;
        private void Grabar_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Grabar_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonFour_Click(object sender, EventArgs e)
        {

        }
    }
}
