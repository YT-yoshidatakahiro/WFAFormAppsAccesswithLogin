using System;
using System.Windows.Forms;

namespace WFAApps201220
{
    public partial class btnDB : Form
    {
        public btnDB()
        {
            InitializeComponent();

            ControlBox = false;

        }

        /// <summary>
        /// ログイン画面へ戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 課題1アクセス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToCalc_Click(object sender, EventArgs e)
        {
            Dentaku1 dk = new Dentaku1();
            dk.ShowDialog();
        }

        /// <summary>
        /// 課題2アクセス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRW_Click(object sender, EventArgs e)
        {
            DataRW todatarw = new DataRW();
            todatarw.ShowDialog();
        }

        /// <summary>
        /// 課題3アクセス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDBase_Click(object sender, EventArgs e)
        {
            DBResister todataDB = new DBResister();
            todataDB.ShowDialog();

        }

        /// <summary>
        /// 課題4の準備アクセス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderSet toorderset = new OrderSet();
            toorderset.ShowDialog();
        }

        /// <summary>
        /// 課題4アクセス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadOrder_Click(object sender, EventArgs e)
        {
            ReadOrder readorder = new ReadOrder();
            readorder.ShowDialog();
        }

        /// <summary>
        /// 課題5アクセス
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoop_Click(object sender, EventArgs e)
        {
            LogLooping loglooping = new LogLooping();
            loglooping.ShowDialog();
        }

        private void btnDB_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 家計簿画面へ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKintai_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FKakeibo().ShowDialog();
            this.Show();
        }
    }
}
