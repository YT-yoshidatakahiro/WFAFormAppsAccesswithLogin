using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WFAApps201220
{
    public partial class DBResister : Form
    {
        public DBResister()
        {
            InitializeComponent();
            ControlBox = false;
        }

        /// <summary>
        /// 閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnDB toDBresister = new btnDB();
            toDBresister.Update();
            this.Close();
        }

        /// <summary>
        /// 追加画面への移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBAdd todbadd = new DBAdd();
            todbadd.ShowDialog();
        }

        /// <summary>
        /// datagridviewへの表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DBResister_Load(object sender, EventArgs e)
        {
            DBAdd main_add = new DBAdd();

            dGVDB.DataSource = main_add.Dat1(main_add.sqllist[4]);

            //インデックス
            if (dGVDB.Rows.Count >= 1)
            {
                for (int i = 0; i < dGVDB.Rows.Count - 1; i++)
                {
                    dGVDB.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        /// <summary>
        /// 変更画面表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCh_Click(object sender, EventArgs e)
        {
            DBChange todbchange = new DBChange();
            todbchange.ShowDialog();
        }

        /// <summary>
        /// 削除画面表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            DBDelete main_delete = new DBDelete();
            main_delete.ShowDialog();
        }

        /// <summary>
        /// グリッドビュー更新ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            DBAdd main_add = new DBAdd();

            dGVDB.DataSource = null;
            dGVDB.DataSource = main_add.Dat1(main_add.sqllist[4]);
        }

        /// <summary>
        /// 未使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGVDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
