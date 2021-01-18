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
    public partial class OrderSet : Form
    {
        public OrderSet()
        {
            InitializeComponent();
            ControlBox = false;
        }

        /// <summary>
        /// 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderSet_Load(object sender, EventArgs e)
        {
            
        }

        private void tbAfter_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBefore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrderASC_Click(object sender, EventArgs e)
        {
            string beforeorder = tbBefore.Text;

            int[] afterorder = new int[beforeorder.Length];

            for (int i = 0; i < afterorder.Length; i++)
            {
                afterorder[i] = Convert.ToInt32(tbBefore.Text.Substring(i, 1));
            }

            int min = 0;
            for (int i = 0; i< afterorder.Length-1;i++)
            {
                for (int j = (afterorder.Length - 1); j> i; j--)
                {
                    if (afterorder[j-1] < afterorder[j])
                    {
                        min = afterorder[j] ;
                        afterorder[j] = afterorder[j - 1];
                        afterorder[j-1] = min;
                    }
                }
            }
            for (int i= 0; i< afterorder.Length; i++)
            {
                tbAfter.Text += afterorder[i].ToString();
            }
        }
    }
}
