using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;


namespace WFAApps201220
{
    public partial class FUserControl : Form
    {
        public FUserControl()
        {
            InitializeComponent();

            ControlBox = false;
        }

        private void FUserControl_Load(object sender, EventArgs e)
        {
            DBAdd usertoadd = new DBAdd();
            cmbUserDelete.DataSource = usertoadd.listjob(usertoadd.pgsqlstr1, usertoadd.sqllist[9], cmbUserDelete, "id", "id");
            cmbNameUp.DataSource = usertoadd.listjob(usertoadd.pgsqlstr1, usertoadd.sqllist[9], cmbNameUp, "id", "id");
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
        /// 管理画面へ戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbUserDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBAdd usertoadd = new DBAdd();
            usertoadd.deleteentry(usertoadd.pgsqlstr1, usertoadd.sqllist[10], cmbUserDelete);
            cmbUpdate();
            MessageBox.Show("削除完了：要更新");
        }

        /// <summary>
        /// ユーザー登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntry_Click(object sender, EventArgs e)
        {
            DBAdd usertoadd = new DBAdd();
            usertoadd.user_addregister(usertoadd.pgsqlstr1, usertoadd.sqllist[11], tbNameEntry, tbPassEntry);
            cmbUpdate();
            tbNameEntry.Text = "";
            tbPassEntry.Text = "";
            MessageBox.Show("登録完了");
        }

        /// <summary>
        /// ユーザー更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DBAdd usertoadd = new DBAdd();
            usertoadd.user_addregister(usertoadd.pgsqlstr1, usertoadd.sqllist[12], tbPassUp, cmbNameUp);

            usertoadd.user_updateentry2(usertoadd.pgsqlstr1, usertoadd.sqllist[13], tbNameUp,tbPassUp);

            cmbUpdate();
            tbNameUp.Text = "";
            tbPassUp.Text = "";
            MessageBox.Show("更新完了");

        }

        /// <summary>
        /// コンボボックス更新関数
        /// </summary>
        public void cmbUpdate()
        {
            DBAdd usertoadd = new DBAdd();
            cmbUserDelete.DataSource = null;
            cmbUserDelete.DataSource = usertoadd.listjob(usertoadd.pgsqlstr1, usertoadd.sqllist[9], cmbUserDelete, "id", "id");
            cmbNameUp.DataSource = null;
            cmbNameUp.DataSource = usertoadd.listjob(usertoadd.pgsqlstr1, usertoadd.sqllist[9], cmbNameUp, "id", "id");
        }

        private void tbPassUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbNameUp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNameUp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
