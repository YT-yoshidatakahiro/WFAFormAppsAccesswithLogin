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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new FUserControl().ShowDialog();
                this.Show();
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
