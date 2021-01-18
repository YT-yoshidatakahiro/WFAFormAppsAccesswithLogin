using System;
using System.Windows.Forms;

namespace WFAApps201220
{
    public partial class Dentaku1 : Form
    {
        public Dentaku1()
        {
            InitializeComponent();
            ControlBox = false;
        }

        static double kekkamoji0 = 0; 
        string kekkamoji1 = "";

        /// <summary>
        /// メイン画面へ戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 結果表示を空白にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbKekka.Text = "";
            kekkamoji0 = 0;
        }

        /// <summary>
        ///結果を％換算 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPer_Click(object sender, EventArgs e)
        {
            tbKekka.Text =(double.Parse(tbKekka.Text) / 100).ToString();
        }

        /// <summary>
        /// 数値の符号を変える
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHugo_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(tbKekka.Text) > 0)
            {
                tbKekka.Text = "-" + tbKekka.Text;
            }else if (Convert.ToDouble(tbKekka.Text) < 0)
            {
                tbKekka.Text = tbKekka.Text.Replace("-", "");
            }
        }

        /// <summary>
        /// 数字の結合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZeros_Click(object sender, EventArgs e)
        {
            if (tbKekka.Text != "")
            {
                tbKekka.Text = "0";
            }
            else
            {
                tbKekka.Text += "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (tbKekka.Text != "")
            {
                tbKekka.Text = "1";
            }
            else
            {
                tbKekka.Text += "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (kekkamoji0 != 0)
            {
                tbKekka.Text = "2";
            }
            else
            {
                tbKekka.Text += "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (kekkamoji0 != 0)
            {
                tbKekka.Text = "3";
            }
            else
            {
                tbKekka.Text += "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (kekkamoji0 != 0)
            {
                tbKekka.Text = "4";
            }
            else
            {
                tbKekka.Text += "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (kekkamoji0 != 0)
            {
                tbKekka.Text = "5";
            }
            else
            {
                tbKekka.Text += "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (kekkamoji0 != 0)
            {
                tbKekka.Text = "6";
            }
            else
            {
                tbKekka.Text += "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (kekkamoji0 != 0)
            {
                tbKekka.Text = "7";
            }
            else
            {
                tbKekka.Text += "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (kekkamoji0 != 0)
            {
                tbKekka.Text = "8";
            }
            else
            {
                tbKekka.Text += "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (kekkamoji0 != 0)
            {
                tbKekka.Text = "9";
            }
            else
            {
                tbKekka.Text += "9";
            }
        }

        private void btndot_Click_1(object sender, EventArgs e)
        {
            if (!tbKekka.Text.Contains("."))
            {
                tbKekka.Text += ".";
            }
            else
            {
            }
        }

        /// <summary>
        /// 加算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            kekkamoji1 = tbKekka.Text;
            tbKekka.Clear();
            kekkamoji0 += Convert.ToDouble(kekkamoji1);
            tbKekka.Text =  Convert.ToString(kekkamoji0);
            kekkamoji1 = "";
        }

        /// <summary>
        /// 減算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (kekkamoji1 == "")
            {
                kekkamoji1 = tbKekka.Text;
                kekkamoji0 = Convert.ToDouble(kekkamoji1);
                tbKekka.Clear();
            }
            else
            {
                kekkamoji1 = tbKekka.Text;
                tbKekka.Clear();
                kekkamoji0 -= Convert.ToDouble(kekkamoji1);
                tbKekka.Text = Convert.ToString(kekkamoji0);
            }
        }

        /// <summary>
        /// 乗算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProd_Click(object sender, EventArgs e)
        {
            if (kekkamoji1 == "")
            {
                kekkamoji1 = tbKekka.Text;
                kekkamoji0 = Convert.ToDouble(kekkamoji1);
                tbKekka.Clear();
            }
            else
            {
                kekkamoji1 = tbKekka.Text;
                tbKekka.Clear();
                kekkamoji0 *= Convert.ToDouble(kekkamoji1);
                tbKekka.Text = Convert.ToString(kekkamoji0);
            }

        }

        /// <summary>
        /// 除算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (kekkamoji1 == "")
            {
                kekkamoji1 = tbKekka.Text;
                kekkamoji0 = Convert.ToDouble(kekkamoji1);
                tbKekka.Clear();
            }
            else
            {
                kekkamoji1 = tbKekka.Text;
                tbKekka.Clear();
                kekkamoji0 /= Convert.ToDouble(kekkamoji1);
                tbKekka.Text = Convert.ToString(kekkamoji0);
            }

        }
        /// <summary>
        /// 未使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dentaku1_Load(object sender, EventArgs e)
        {
        }
        private void btndot_Click(object sender, EventArgs e)
        {
        }
        private void tbKekka_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
