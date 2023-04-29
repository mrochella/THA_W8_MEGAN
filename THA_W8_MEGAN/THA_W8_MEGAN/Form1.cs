using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W8_MEGAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 pData; //show player data
        Form3 mDetails; //show match details

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel_pewpew.Controls.Clear();
            pData = new Form2();
            pData.TopLevel = false;
            pData.Dock = DockStyle.Fill;
            this.panel_pewpew.Controls.Add(pData);
            pData.Show();
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel_pewpew.Controls.Clear();
            mDetails = new Form3();
            mDetails.TopLevel = false;
            mDetails.Dock = DockStyle.Fill;
            this.panel_pewpew.Controls.Add(mDetails);
            mDetails.Show();
        }
    }
}
