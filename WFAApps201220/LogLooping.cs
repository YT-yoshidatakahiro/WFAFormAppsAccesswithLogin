using System;
using System.Windows.Forms;
using System.IO;

namespace WFAApps201220
{
    public partial class LogLooping : Form
    {
        public LogLooping()
        {
            InitializeComponent();
            ControlBox = false;
        }

        /// <summary>
        /// 処理開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            string signalpath = "kadai5signal.txt";
            string logpath = "kadai5log.txt";
            //変数設定
            string number1 = "00000";
            string signal="";
            string kekka="";
            string signal_old = number1;
            DateTime dt = DateTime.Now;
            long savetime = long.Parse(dt.ToString("yyyyMMddhhmmss"));

            //ログファイルの読込
            StreamReader logR1 = new StreamReader(logpath);
            tblog.Text = logR1.ReadToEnd();
            logR1.Close();

            //シグナルファイルの設定
            signal = signalkekka(signalpath, signal);

            while (true)
            {
                //タイマ3秒間隔
                tmTimer.Interval = 3000;
                tmTimer.Start();

                long savetime_new = long.Parse(File.GetLastWriteTime(signalpath).ToString("yyyyMMddhhmmss"));
                
                //シグナル読込
                if (savetime < savetime_new)
                {
                    signal = signalkekka(signalpath, signal);
                }

                if (signal == signal_old)
                {
                    signal_old = signal;
                }
                else
                {
                    //書き込み内容の設定
                    string[] hantei = { "異常", "正常" };

                    if (signal.Contains("1"))
                    {
                        MessageBox.Show("異常発生");

                        logwrite(logpath, signal, hantei[0]);

                        //ログ読込
                        logR1 = new StreamReader(logpath);

                        tblog.Text = logR1.ReadToEnd();

                        logR1.Close();
                    }
                    else if (!signal.Contains("1"))
                    {
                        logwrite(logpath, signal, hantei[1]);

                        //ログ読込
                        logR1 = new StreamReader(logpath);

                        tblog.Text = logR1.ReadToEnd();

                        logR1.Close();
                    }
                    signal_old = signal;
                }
            }
        }

        /// <summary>
        /// シグナル取得関数
        /// </summary>
        /// <param name="signal"></param>
        /// <returns></returns>
        public string signalkekka(string path, string signal)
        {
            //シグナルファイルの設定
            byte[] test = new byte[1024];
            Stream l_fileStream = File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader test1 = new StreamReader(l_fileStream);
            signal = test1.ReadToEnd();
            test1.Close();
            l_fileStream.Close();
            return signal;
        }

        /// <summary>
        /// 書き込み設定関数
        /// </summary>
        /// <param name="signal"></param>
        public void logwrite(string path, string signal, string hantei)
        {
            DateTime dt = new DateTime();

            //書き込み内容
            string kekka = dt.ToString("yyyy/MM/dd ") + signal + " " + hantei;

            //ログ書き込み
            logwriteset(path, kekka);
        }

        /// <summary>
        /// 書き込みセッティング
        /// </summary>
        /// <param name="path"></param>
        /// <param name="kekka"></param>
        public void logwriteset(string path, string kekka)
        {
            StreamWriter logW = new StreamWriter(path, true);
            logW.WriteLine(kekka);
            logW.Close();
        }

        /// <summary>
        /// ログファイルを開く
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenlog_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// シグナルを入力する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignal_Click(object sender, EventArgs e)
        {
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
        /// 未使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmTimer_Tick(object sender, EventArgs e)
        {

        }

        private void tbSignal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
