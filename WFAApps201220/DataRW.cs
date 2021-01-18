using System;
using System.IO;
using System.Windows.Forms;

namespace WFAApps201220
{
    public partial class DataRW : Form
    {
        public DataRW()
        {
            InitializeComponent();

            ControlBox = false;

            btnWrite.Enabled = false;
        }
        /// <summary>
        /// 読込 100行まで読込。101以降は不可
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                ReadRWFunction("kadai2dat.csv");
            }
            catch (Exception)
            {
                MessageBox.Show("読込不可");
            }

            //データがあれば書込
            if (dGVData.Rows.Count>0)
            {
                btnWrite.Enabled = true;
            }
        }

        /// <summary>
        /// メインへ戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnDB tomain1 = new btnDB();
            tomain1.Update();
            this.Close();
        }

        /// <summary>
        /// 書き込み
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        string dat1row_write;

        private void btnWrite_Click(object sender, EventArgs e)
        {

            string datw_path = "kdai2dat_write.csv";

            if (!File.Exists(datw_path))
            {
                File.Create(datw_path);
            }

            WriteWFunction(datw_path);

        }

        /// <summary>
        /// ファイル読み込み関数
        /// </summary>
        /// <param name="name1"></param>
        public void ReadRWFunction(string name1)
        {
            dGVData.Rows.Clear();
            
            StreamReader datR = new StreamReader(name1);

            while (datR.EndOfStream == false)
            {
                if (dGVData.Rows.Count == 101)
                {
                    break;
                }

                string[] dat1row = datR.ReadLine().Split(',');

                dGVData.Rows.Add(dat1row);
            }

            datR.Close();

            //インデックス書き込み
            for (int i = 0; i < dGVData.Rows.Count - 1; i++)
            {
                dGVData.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        /// <summary>
        /// ファイル書き込み関数
        /// </summary>
        /// <param name="name2"></param>
        public void WriteWFunction(string name2)
        {
            StreamWriter datW = new StreamWriter(name2);
            for (int i = 0; i < dGVData.Rows.Count - 1; i++)
            {
                dat1row_write = dGVData.Rows[i].HeaderCell.Value.ToString();

                for (int j = 0; j < dGVData.Columns.Count; j++)
                {
                    dat1row_write += dGVData.Rows[i].Cells[j].Value;
                }

                datW.WriteLine(dat1row_write);

                dat1row_write = "";
            }

            datW.Close();
            MessageBox.Show("書込完了");
        }
    }
}
