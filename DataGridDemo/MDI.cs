using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridDemo
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void crudFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            f1.MdiParent = this;
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.MdiParent = this;
        }
    }
}
