using System;
using System.Windows.Forms;
namespace Assignment3_Library
{
    public partial class baseMainForm : Form
    {
        public baseMainForm()
        {
            InitializeComponent();
        }



        protected virtual void OathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Base Oath");
            throw new NotSupportedException();
        }

        protected virtual void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Base About");
            throw new NotSupportedException();
        }
    }
}
