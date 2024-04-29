using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitachi_SPACE_Programme
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de");
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
