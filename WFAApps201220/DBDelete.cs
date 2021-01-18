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
    public partial class DBDelete : Form
    {
        public DBDelete()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void DBDelete_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 削除設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBAdd delete_add = new DBAdd();

            try
            {
                if (!tbNo.Text.Equals(delete_add.EntryNo(delete_add.sqllist[5], tbNo).ToString()))
                {
                    MessageBox.Show("登録番号不一致");
                }
                else
                {
                    MessageBox.Show("削除完了");
                    delete_add.deleteentry(delete_add.pgsqlstr1, delete_add.sqllist[7],tbNo);
                    tbNo.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("番号未入力");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
