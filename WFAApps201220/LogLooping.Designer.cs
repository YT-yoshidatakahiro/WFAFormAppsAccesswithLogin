namespace WFAApps201220
{
    partial class LogLooping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblog = new System.Windows.Forms.TextBox();
            this.btnOpenlog = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSignal = new System.Windows.Forms.Button();
            this.tmTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tblog
            // 
            this.tblog.Location = new System.Drawing.Point(12, 12);
            this.tblog.Multiline = true;
            this.tblog.Name = "tblog";
            this.tblog.Size = new System.Drawing.Size(425, 228);
            this.tblog.TabIndex = 0;
            this.tblog.TextChanged += new System.EventHandler(this.tblog_TextChanged);
            // 
            // btnOpenlog
            // 
            this.btnOpenlog.Location = new System.Drawing.Point(189, 244);
            this.btnOpenlog.Name = "btnOpenlog";
            this.btnOpenlog.Size = new System.Drawing.Size(106, 42);
            this.btnOpenlog.TabIndex = 1;
            this.btnOpenlog.Text = "入力ファイル開く";
            this.btnOpenlog.UseVisualStyleBackColor = true;
            this.btnOpenlog.Click += new System.EventHandler(this.btnOpenlog_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 246);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 42);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "処理開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(333, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "メインへ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSignal
            // 
            this.btnSignal.Location = new System.Drawing.Point(93, 245);
            this.btnSignal.Name = "btnSignal";
            this.btnSignal.Size = new System.Drawing.Size(90, 41);
            this.btnSignal.TabIndex = 4;
            this.btnSignal.Text = "信号入力";
            this.btnSignal.UseVisualStyleBackColor = true;
            this.btnSignal.Click += new System.EventHandler(this.btnSignal_Click);
            // 
            // tmTimer
            // 
            this.tmTimer.Interval = 2000;
            this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // LogLooping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 322);
            this.Controls.Add(this.btnSignal);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnOpenlog);
            this.Controls.Add(this.tblog);
            this.Name = "LogLooping";
            this.Text = "ループ処理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tblog;
        private System.Windows.Forms.Button btnOpenlog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSignal;
        private System.Windows.Forms.Timer tmTimer;
    }
}