namespace WFAApps201220
{
    partial class DBResister
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dGVDB = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 264);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 55);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "メインへ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 55);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCh
            // 
            this.btnCh.Location = new System.Drawing.Point(198, 264);
            this.btnCh.Name = "btnCh";
            this.btnCh.Size = new System.Drawing.Size(87, 55);
            this.btnCh.TabIndex = 2;
            this.btnCh.Text = "変更";
            this.btnCh.UseVisualStyleBackColor = true;
            this.btnCh.Click += new System.EventHandler(this.btnCh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(291, 264);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(87, 55);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "削除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dGVDB
            // 
            this.dGVDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDB.Location = new System.Drawing.Point(12, 42);
            this.dGVDB.Name = "dGVDB";
            this.dGVDB.RowHeadersWidth = 50;
            this.dGVDB.RowTemplate.Height = 21;
            this.dGVDB.Size = new System.Drawing.Size(366, 216);
            this.dGVDB.TabIndex = 4;
            this.dGVDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDB_CellContentClick);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(272, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 26);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "グリッドビュー更新";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // DBResister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 329);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dGVDB);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Name = "DBResister";
            this.Text = "DB登録";
            this.Load += new System.EventHandler(this.DBResister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCh;
        private System.Windows.Forms.Button btnDel;
        public System.Windows.Forms.DataGridView dGVDB;
        private System.Windows.Forms.Button btnReload;
    }
}