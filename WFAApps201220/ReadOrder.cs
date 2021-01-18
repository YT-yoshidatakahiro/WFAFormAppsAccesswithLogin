using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFAApps201220
{
    public partial class ReadOrder : Form
    {
        public ReadOrder()
        {
            InitializeComponent();
            ControlBox = false;
        }

        /// <summary>
        /// 2ファイル読み込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            ReadFunction("Book1.csv", "Book2.csv");
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

        /// <summary>
        /// 2ファイル読み込み関数_昇順への並べ替え
        /// </summary>
        public void ReadFunction(string name1, string name2)
        {
            StreamReader R1 = new StreamReader(name1);
            StreamReader R2 = new StreamReader(name2);

            while (R1.EndOfStream == false)
            {
                dGV1.Rows.Add(R1.ReadLine().Split(','));
            }
            while (R2.EndOfStream == false)
            {
                dGV2.Rows.Add(R2.ReadLine().Split(','));
            }
            //インデックス書き込み
            for (int i = 0; i < dGV1.Rows.Count - 1; i++)
            {
                dGV1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            for (int i = 0; i < dGV2.Rows.Count - 1; i++)
            {
                dGV2.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        /// <summary>
        /// 並べ替え
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int num1_1 = 0;
            int num2_1 = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            while ( i < dGV1.Rows.Count || j < dGV2.Rows.Count)
            {
                    num1 = Convert.ToInt32(dGV1.Rows[i].Cells[0].Value);
                    num2 = Convert.ToInt32(dGV2.Rows[j].Cells[0].Value);


                if (num1 == 0|| num2 == 0)
                {
                    if (num2 > num1)
                    {
                        j = num1_1 - 1;
                        while (j <= dGV2.Rows.Count - 1)
                        {
                            dGV3.Rows.Add();
                            dGV3.Rows[k].Cells[0].Value = dGV2.Rows[j].Cells[0].Value;
                            dGV3.Rows[k].Cells[1].Value = dGV2.Rows[j].Cells[1].Value;
                            j++;
                            k++;
                        }
                    }
                    if (num1 > num2)
                    {
                        i = num2_1 - 1;
                        while (i <= dGV1.Rows.Count - 1)
                        {
                            dGV3.Rows.Add();
                            dGV3.Rows[k].Cells[0].Value = dGV1.Rows[i].Cells[0].Value;
                            dGV3.Rows[k].Cells[1].Value = dGV1.Rows[i].Cells[1].Value;
                            i++;
                            k++;
                        }
                    }
                    break;
                }
                if (num2 > num1)
                {
                    dGV3.Rows.Add();
                    dGV3.Rows[k].Cells[0].Value = num1;
                    dGV3.Rows[k].Cells[1].Value = dGV1.Rows[i].Cells[1].Value;
                    num1_1 = i;
                    i++;
                    k++;
                }
                if (num2 < num1)
                {
                    dGV3.Rows.Add();
                    dGV3.Rows[k].Cells[0].Value = num2;
                    dGV3.Rows[k].Cells[1].Value = dGV2.Rows[j].Cells[1].Value;
                    num2_1 = j;
                    j++;
                    k++;
                }
            }
        }

        /// <summary>
        /// 未使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGV3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
