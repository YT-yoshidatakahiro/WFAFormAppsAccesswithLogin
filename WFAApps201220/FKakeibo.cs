using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAApps201220
{
    public partial class FKakeibo : Form
    {
        public FKakeibo()
        {
            InitializeComponent();
        }

        private void mCaren_DateChanged(object sender, DateRangeEventArgs e)
        {
            new FsyushiEntry().ShowDialog();

        }

        private void FKakeibo_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception)
            {

            }
        }

        private void btnToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGV3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dGV6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
