using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WFAApps201220
{
    public partial class DBAdd : Form
    {
        public DBAdd()
        {
            InitializeComponent();
            ControlBox = false;
        }

        /// <summary>
        /// DBパス
        /// </summary>
        public string pgsqlstr1 =
                             "Dsn=PostgreSQL35Wkadai64;" +
                             "Server =localhost;" +
                             "Port = 5432;" +
                             "User id=postgres;" +
                             "Pwd=postgres;" +
                             "DataBase=kaiin";
        
        /// <summary>
        /// sqlリスト
        /// </summary>
        public string[] sqllist =
        {
            "insert into kaiin (id, gender, job, name) values(?, ?, ?, ?)",
            "select * from job order by id asc",
            "select * from gender order by id asc",
            "select max(id) from kaiin",
            "select * from kaiin order by id asc",
            "select id from kaiin where id = ?",
            "update kaiin set gender = ?, job = ?, name = ? where id = ?",
            "delete from kaiin where id = ?",
            "select * from login",
            "select id from login order by pass asc",
            "delete from login where id = ?",
            "insert into login (id, pass) values(?, ?)",
            "update login set pass = ? where id = ?",
            "update login set id = ? where pass = ?"
    };

        /// <summary>
        /// 追加設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBResister add_main = new DBResister();
            //登録不備時
            if (tbName.Text == "" || cmbGen.Text =="" || cmbJob.Text =="")
            {
                MessageBox.Show("空白あり");
            }
            else
            {
                //登録制常時処理
                MessageBox.Show("登録完了");

                addregister(pgsqlstr1, sqllist[0],tbNo, cmbGen, cmbJob, tbName);

                //登録後後処理
                cmbGen.Text = "";
                cmbJob.Text = "";
                tbName.Text = "";

            }
        }

        /// <summary>
        /// 追加画面初期表示時の設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DBAdd_Load(object sender, EventArgs e)
        {

            //性別コンボボックス//
            cmbGen.DataSource = listjob(pgsqlstr1, sqllist[2], cmbGen,"gender","id");

            //職種コンボボックス//
            cmbJob.DataSource = listjob(pgsqlstr1, sqllist[1], cmbJob, "job","id"); 

            //番号テキストボックス
            if (tbNo.Text == "0")
            {
                tbNo.Text = "1";
            }
            else
            {
                tbNo.Text = No(sqllist[3]);
            }
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
        /// 登録番号設定関数
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string No(string path)
        {
            //gridview表示//
            int intno;

            OdbcConnection maindbregister = new OdbcConnection(pgsqlstr1);

            OdbcCommand pgconnno2 = new OdbcCommand(path, maindbregister);

            maindbregister.Open();

            intno = Convert.ToInt32(pgconnno2.ExecuteScalar()) + 1;

            return intno.ToString();
        }

        /// <summary>
        /// 性別・職種コンボボックス関数
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DataTable listjob(string odpath, string path, ListControl name,string disname, string valname)
        {
            DataTable addjob2 = new DataTable();

            OdbcConnection maindbregister = new OdbcConnection(odpath);

            OdbcCommand pgconnjob2 = new OdbcCommand(path, maindbregister);

            OdbcDataAdapter pgconnjob3 = new OdbcDataAdapter(pgconnjob2);

            pgconnjob3.Fill(addjob2);

            name.DisplayMember = disname;

            name.ValueMember = valname;

            return addjob2;
        }

        /// <summary>
        /// 追加登録関数
        /// </summary>
        public void addregister(string odpath, string path, Control no, Control gen, Control job, Control name)
        {
            OdbcConnection addregister = new OdbcConnection(odpath);

            OdbcCommand pgconn2 = new OdbcCommand(path, addregister);

            pgconn2.Parameters.Add(new OdbcParameter("@id", no.Text));

            pgconn2.Parameters.Add(new OdbcParameter("@gender", gen.Text));

            pgconn2.Parameters.Add(new OdbcParameter("@job", job.Text));

            pgconn2.Parameters.Add(new OdbcParameter("@name", name.Text));

            addregister.Open();

            pgconn2.ExecuteNonQuery();

            addregister.Close();
        }

        /// <summary>
        /// ユーザー追加更新関数
        /// </summary>
        public void user_addregister(string odpath, string path, Control pass,Control id)
        {
            OdbcConnection addregister = new OdbcConnection(odpath);

            OdbcCommand pgconn2 = new OdbcCommand(path, addregister);

            pgconn2.Parameters.Add(new OdbcParameter("@pass", pass.Text));

            pgconn2.Parameters.Add(new OdbcParameter("@id", id.Text));

            addregister.Open();

            pgconn2.ExecuteNonQuery();

            addregister.Close();
        }

        /// <summary>
        /// ユーザーid更新関数
        /// </summary>
        public void user_updateentry2(string odpath, string path, Control id1, Control pass)
        {
            OdbcConnection addregister_user = new OdbcConnection(odpath);

            OdbcCommand pgconn2_user = new OdbcCommand(path, addregister_user);

            pgconn2_user.Parameters.Add(new OdbcParameter("@id", id1.Text));

            pgconn2_user.Parameters.Add(new OdbcParameter("@pass", pass.Text));

            addregister_user.Open();

            pgconn2_user.ExecuteNonQuery();

            addregister_user.Close();
        }

        /// <summary>
        /// 登録情報検索関数
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public int EntryNo(string path, Control name)
        {

            OdbcConnection addregister = new OdbcConnection(pgsqlstr1);

            OdbcCommand pgconn2 = new OdbcCommand(path, addregister);

            pgconn2.Parameters.Add(new OdbcParameter("@id", Convert.ToInt32(name.Text)));

            int nocount;

            addregister.Open();

            nocount = Convert.ToInt32(pgconn2.ExecuteScalar());

            addregister.Close();

            return nocount;
        }

        /// <summary>
        /// 登録情報更新関数
        /// </summary>
        public void updateentry(string path, Control gen, Control job, Control name, Control no)
        {
            OdbcConnection addregister = new OdbcConnection(pgsqlstr1);

            OdbcCommand pgconn2 = new OdbcCommand(path, addregister);

            pgconn2.Parameters.Add(new OdbcParameter("@gender", gen.Text));

            pgconn2.Parameters.Add(new OdbcParameter("@job", job.Text));

            pgconn2.Parameters.Add(new OdbcParameter("@name", name.Text));

            pgconn2.Parameters.Add(new OdbcParameter("@id", Convert.ToInt32(no.Text)));

            addregister.Open();

            pgconn2.ExecuteNonQuery();

            addregister.Close();
        }


        /// <summary>
        /// 登録情報削除関数
        /// </summary>
        /// <param name="path"></param>
        /// <param name="no"></param>
        public void deleteentry(string odpath, string path, Control no)
        {
            OdbcConnection addregister = new OdbcConnection(odpath);

            OdbcCommand pgconn2 = new OdbcCommand(path, addregister);

            pgconn2.Parameters.Add(new OdbcParameter("@id", no.Text));

            addregister.Open();

            pgconn2.ExecuteNonQuery();

            addregister.Close();
        }

        /// <summary>
        /// gridview表示関数
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public DataTable Dat1(string path)
        {
            DataTable maindb2 = new DataTable();

            OdbcConnection maindbregister = new OdbcConnection(pgsqlstr1);

            OdbcCommand pgconn2 = new OdbcCommand(path, maindbregister);

            OdbcDataAdapter pgconn3 = new OdbcDataAdapter(pgconn2);

            pgconn3.Fill(maindb2);

            return maindb2;
        }

        /// <summary>
        /// 未使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
