using System;
using System.Windows.Forms;
using System.Data.Odbc;


namespace WFAApps201220
{
    public partial class DBChange : Form
    {

        public DBChange()
        {
            InitializeComponent();
            ControlBox = false;
        }

        /// <summary>
        /// 変更画面読み込み時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DBChange_Load(object sender, EventArgs e)
        {
            DBAdd change_add = new DBAdd();

            //性別コンボボックス//
            cmbGen.DataSource = change_add.listjob(change_add.pgsqlstr1, change_add.sqllist[2], cmbGen,"gender","id");

            //職種コンボボックス//
            cmbJob.DataSource = change_add.listjob(change_add.pgsqlstr1,change_add.sqllist[1], cmbJob, "job", "id");

        }

        /// <summary>
        /// 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 変更設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBAdd change_add = new DBAdd();

            try
            {
                if (!tbNo.Text.Equals(change_add.EntryNo(change_add.sqllist[5],tbNo).ToString()))
                {
                    MessageBox.Show("登録番号不一致");
                }
                else
                {
                    MessageBox.Show("変更完了");
                    change_add.updateentry(change_add.sqllist[6], cmbGen, cmbJob, tbName, tbNo);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("番号未入力");
            }
        }

        /// <summary>
        /// 未使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tbNo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
