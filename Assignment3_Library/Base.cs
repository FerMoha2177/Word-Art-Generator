using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_Library
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();

        }

        Point downPoint = Point.Empty;

        void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = new Point(e.X, e.Y);
        }

        void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty) return;
            Point location =
                new Point(
                    this.Left + e.X - downPoint.X,
                    this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = Point.Empty;
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDlg.Color;
                if (childColorUpdate != null)
                {
                    childColorUpdate(this, EventArgs.Empty);
                }
            }
            Console.WriteLine("THIS IS THE FIRST ONE");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDlg.Color;
                if (childColorUpdate != null)
                {
                    childColorUpdate(this, EventArgs.Empty);
                }
            }

            Console.WriteLine("THIS IS THE SECOND ONE");
        }

        private void closeChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preferencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        public event EventHandler childColorUpdate;

    }
}
