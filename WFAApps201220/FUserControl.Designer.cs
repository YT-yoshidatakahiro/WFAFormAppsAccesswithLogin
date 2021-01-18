namespace WFAApps201220
{
    partial class FUserControl
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
            this.tbNameEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassEntry = new System.Windows.Forms.TextBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPassUp = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbUserDelete = new System.Windows.Forms.ComboBox();
            this.btnToAdmin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbNameUp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNameUp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNameEntry
            // 
            this.tbNameEntry.Location = new System.Drawing.Point(169, 50);
            this.tbNameEntry.Name = "tbNameEntry";
            this.tbNameEntry.Size = new System.Drawing.Size(126, 19);
            this.tbNameEntry.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ユーザー新規追加";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ユーザーID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "ユーザーパスワード";
            // 
            // tbPassEntry
            // 
            this.tbPassEntry.Location = new System.Drawing.Point(168, 78);
            this.tbPassEntry.Name = "tbPassEntry";
            this.tbPassEntry.Size = new System.Drawing.Size(126, 19);
            this.tbPassEntry.TabIndex = 0;
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(202, 9);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(93, 29);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "下記で登録";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label4.Location = new System.Drawing.Point(11, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "ユーザー削除";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label5.Location = new System.Drawing.Point(11, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "ユーザーID変更前";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label6.Location = new System.Drawing.Point(11, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "ユーザーパスワード";
            // 
            // tbPassUp
            // 
            this.tbPassUp.Location = new System.Drawing.Point(168, 206);
            this.tbPassUp.Name = "tbPassUp";
            this.tbPassUp.Size = new System.Drawing.Size(126, 19);
            this.tbPassUp.TabIndex = 0;
            this.tbPassUp.TextChanged += new System.EventHandler(this.tbPassUp_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(201, 112);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 29);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "下記で更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label7.Location = new System.Drawing.Point(11, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "ユーザーID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(201, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "下記を削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbUserDelete
            // 
            this.cmbUserDelete.FormattingEnabled = true;
            this.cmbUserDelete.Location = new System.Drawing.Point(168, 275);
            this.cmbUserDelete.Name = "cmbUserDelete";
            this.cmbUserDelete.Size = new System.Drawing.Size(126, 20);
            this.cmbUserDelete.TabIndex = 3;
            this.cmbUserDelete.SelectedIndexChanged += new System.EventHandler(this.cmbUserDelete_SelectedIndexChanged);
            // 
            // btnToAdmin
            // 
            this.btnToAdmin.Location = new System.Drawing.Point(113, 319);
            this.btnToAdmin.Name = "btnToAdmin";
            this.btnToAdmin.Size = new System.Drawing.Size(93, 29);
            this.btnToAdmin.TabIndex = 2;
            this.btnToAdmin.Text = "管理者画面へ";
            this.btnToAdmin.UseVisualStyleBackColor = true;
            this.btnToAdmin.Click += new System.EventHandler(this.btnToAdmin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(212, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbNameUp
            // 
            this.cmbNameUp.FormattingEnabled = true;
            this.cmbNameUp.Location = new System.Drawing.Point(168, 148);
            this.cmbNameUp.Name = "cmbNameUp";
            this.cmbNameUp.Size = new System.Drawing.Size(126, 20);
            this.cmbNameUp.TabIndex = 4;
            this.cmbNameUp.SelectedIndexChanged += new System.EventHandler(this.cmbNameUp_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label8.Location = new System.Drawing.Point(11, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "ユーザーID変更後";
            // 
            // tbNameUp
            // 
            this.tbNameUp.Location = new System.Drawing.Point(168, 178);
            this.tbNameUp.Name = "tbNameUp";
            this.tbNameUp.Size = new System.Drawing.Size(126, 19);
            this.tbNameUp.TabIndex = 6;
            this.tbNameUp.TextChanged += new System.EventHandler(this.tbNameUp_TextChanged);
            // 
            // FUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 368);
            this.Controls.Add(this.tbNameUp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbNameUp);
            this.Controls.Add(this.cmbUserDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnToAdmin);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassEntry);
            this.Controls.Add(this.tbNameEntry);
            this.Name = "FUserControl";
            this.Text = "ユーザー管理";
            this.Load += new System.EventHandler(this.FUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassEntry;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassUp;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnToAdmin;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ComboBox cmbUserDelete;
        private System.Windows.Forms.ComboBox cmbNameUp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNameUp;
    }
}