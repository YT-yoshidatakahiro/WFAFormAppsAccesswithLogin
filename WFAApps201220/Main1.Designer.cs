namespace WFAApps201220
{
    partial class btnDB
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnToCalc = new System.Windows.Forms.Button();
            this.btnRW = new System.Windows.Forms.Button();
            this.btnDBase = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReadOrder = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnReturnLogin = new System.Windows.Forms.Button();
            this.btnKakeibo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 44);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnToCalc
            // 
            this.btnToCalc.Location = new System.Drawing.Point(105, 12);
            this.btnToCalc.Name = "btnToCalc";
            this.btnToCalc.Size = new System.Drawing.Size(87, 44);
            this.btnToCalc.TabIndex = 1;
            this.btnToCalc.TabStop = false;
            this.btnToCalc.Text = "課題1";
            this.btnToCalc.UseVisualStyleBackColor = true;
            this.btnToCalc.Click += new System.EventHandler(this.btnToCalc_Click);
            // 
            // btnRW
            // 
            this.btnRW.Location = new System.Drawing.Point(198, 12);
            this.btnRW.Name = "btnRW";
            this.btnRW.Size = new System.Drawing.Size(87, 44);
            this.btnRW.TabIndex = 2;
            this.btnRW.TabStop = false;
            this.btnRW.Text = "課題2";
            this.btnRW.UseVisualStyleBackColor = true;
            this.btnRW.Click += new System.EventHandler(this.btnRW_Click);
            // 
            // btnDBase
            // 
            this.btnDBase.Location = new System.Drawing.Point(291, 12);
            this.btnDBase.Name = "btnDBase";
            this.btnDBase.Size = new System.Drawing.Size(87, 44);
            this.btnDBase.TabIndex = 3;
            this.btnDBase.TabStop = false;
            this.btnDBase.Text = "課題3";
            this.btnDBase.UseVisualStyleBackColor = true;
            this.btnDBase.Click += new System.EventHandler(this.btnDBase_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(384, 12);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(87, 44);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.TabStop = false;
            this.btnOrder.Text = "降順";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReadOrder
            // 
            this.btnReadOrder.Location = new System.Drawing.Point(384, 62);
            this.btnReadOrder.Name = "btnReadOrder";
            this.btnReadOrder.Size = new System.Drawing.Size(87, 41);
            this.btnReadOrder.TabIndex = 5;
            this.btnReadOrder.TabStop = false;
            this.btnReadOrder.Text = "課題4";
            this.btnReadOrder.UseVisualStyleBackColor = true;
            this.btnReadOrder.Click += new System.EventHandler(this.btnReadOrder_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(477, 12);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(85, 44);
            this.btnLoop.TabIndex = 6;
            this.btnLoop.Text = "課題5";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnReturnLogin
            // 
            this.btnReturnLogin.Location = new System.Drawing.Point(12, 62);
            this.btnReturnLogin.Name = "btnReturnLogin";
            this.btnReturnLogin.Size = new System.Drawing.Size(87, 41);
            this.btnReturnLogin.TabIndex = 7;
            this.btnReturnLogin.Text = "ログイン画面へ";
            this.btnReturnLogin.UseVisualStyleBackColor = true;
            this.btnReturnLogin.Click += new System.EventHandler(this.btnReturnLogin_Click);
            // 
            // btnKakeibo
            // 
            this.btnKakeibo.Location = new System.Drawing.Point(568, 12);
            this.btnKakeibo.Name = "btnKakeibo";
            this.btnKakeibo.Size = new System.Drawing.Size(85, 44);
            this.btnKakeibo.TabIndex = 8;
            this.btnKakeibo.Text = "家計簿";
            this.btnKakeibo.UseVisualStyleBackColor = true;
            this.btnKakeibo.Click += new System.EventHandler(this.btnKintai_Click);
            // 
            // btnDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 124);
            this.Controls.Add(this.btnKakeibo);
            this.Controls.Add(this.btnReturnLogin);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.btnReadOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDBase);
            this.Controls.Add(this.btnRW);
            this.Controls.Add(this.btnToCalc);
            this.Controls.Add(this.btnClose);
            this.Name = "btnDB";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.btnDB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnToCalc;
        private System.Windows.Forms.Button btnRW;
        private System.Windows.Forms.Button btnDBase;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReadOrder;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnReturnLogin;
        private System.Windows.Forms.Button btnKakeibo;
    }
}

