using System;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;

namespace WFAApps201220
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            ControlBox = false;
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
        /// ログイン設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            gamenseni(btnLogin, 8);
        }

        /// <summary>
        /// 管理者画面へ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            gamenseni(btnAdmin, 8); 
        }
        
        public void gamenseni(Object obje, int pathnum)
        {
            DataTable logindat = new DataTable();
            FUserControl usercont = new FUserControl();

            DBAdd logintoDBAdd = new DBAdd();

            OdbcConnection maindbregister = new OdbcConnection(logintoDBAdd.pgsqlstr1);
            OdbcCommand pgconnno2 = new OdbcCommand(logintoDBAdd.sqllist[pathnum], maindbregister);
            OdbcDataAdapter pgconn3 = new OdbcDataAdapter(pgconnno2);
            pgconn3.Fill(logindat);

            maindbregister.Open();
            try
            {
                if (obje.ToString().Contains(btnLogin.Text))
                {
                    for (int i = 0; i < logindat.Rows.Count; i++)
                    {
                        if (tbID.Text == logindat.Rows[i].Field<string>("id") && tbPass.Text == logindat.Rows[i].Field<string>("pass"))
                        {
                            this.Hide();
                            new btnDB().ShowDialog();
                            tbID.Text = "";
                            tbPass.Text = "";
                            this.Show();
                            break;
                        }else
                        {
                            if (i == logindat.Rows.Count - 1)
                            {
                                MessageBox.Show("IDまたはパスワードが違います");
                            }
                            continue;
                        }
                    }
                }

                if (obje.ToString().Contains(btnAdmin.Text))
                {
                    if (!tbPass.Text.StartsWith("A"))
                    {
                        MessageBox.Show("管理者ではありません");
                    }
                    else
                    {
                        for (int i = 0; i < logindat.Rows.Count; i++)
                        {
                            if (tbID.Text == logindat.Rows[i].Field<string>("id") && tbPass.Text == logindat.Rows[i].Field<string>("pass"))
                            {
                                this.Hide();
                                new FAdmin().ShowDialog();
                                tbID.Text = "";
                                tbPass.Text = "";
                                this.Show();
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// 未使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
