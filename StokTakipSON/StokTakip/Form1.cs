using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BrandsManage().Show();
        }

        private void telefonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Phones().Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting.ChangeLanguage(Language.tr);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting.ChangeLanguage(Language.en);
            this.Controls.Clear();
            InitializeComponent();
        }

        private void phoneCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhoneCaseManage().Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SalesForm().Show();
        }
    }
}
