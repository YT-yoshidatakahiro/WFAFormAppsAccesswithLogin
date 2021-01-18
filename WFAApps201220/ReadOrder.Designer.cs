namespace WFAApps201220
{
    partial class ReadOrder
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
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV2 = new System.Windows.Forms.DataGridView();
            this.col1_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV3 = new System.Windows.Forms.DataGridView();
            this.col3_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV3)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2});
            this.dGV1.Location = new System.Drawing.Point(12, 83);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowTemplate.Height = 21;
            this.dGV1.Size = new System.Drawing.Size(183, 248);
            this.dGV1.TabIndex = 0;
            this.dGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellContentClick);
            // 
            // col1
            // 
            this.col1.HeaderText = "id";
            this.col1.Name = "col1";
            // 
            // col2
            // 
            this.col2.HeaderText = "name";
            this.col2.Name = "col2";
            // 
            // dGV2
            // 
            this.dGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1_2,
            this.col2_2});
            this.dGV2.Location = new System.Drawing.Point(201, 83);
            this.dGV2.Name = "dGV2";
            this.dGV2.RowTemplate.Height = 21;
            this.dGV2.Size = new System.Drawing.Size(183, 248);
            this.dGV2.TabIndex = 1;
            this.dGV2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV2_CellContentClick);
            // 
            // col1_2
            // 
            this.col1_2.HeaderText = "id";
            this.col1_2.Name = "col1_2";
            // 
            // col2_2
            // 
            this.col2_2.HeaderText = "name";
            this.col2_2.Name = "col2_2";
            // 
            // dGV3
            // 
            this.dGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col3_1,
            this.col3_2});
            this.dGV3.Location = new System.Drawing.Point(390, 83);
            this.dGV3.Name = "dGV3";
            this.dGV3.RowTemplate.Height = 21;
            this.dGV3.Size = new System.Drawing.Size(183, 248);
            this.dGV3.TabIndex = 2;
            this.dGV3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV3_CellContentClick);
            // 
            // col3_1
            // 
            this.col3_1.HeaderText = "id";
            this.col3_1.Name = "col3_1";
            // 
            // col3_2
            // 
            this.col3_2.HeaderText = "name";
            this.col3_2.Name = "col3_2";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "メインへ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(112, 35);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(83, 42);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "読込";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(201, 35);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(89, 38);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "並べ替え";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // ReadOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 354);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dGV3);
            this.Controls.Add(this.dGV2);
            this.Controls.Add(this.dGV1);
            this.Name = "ReadOrder";
            this.Text = "読込後昇順";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.DataGridView dGV2;
        private System.Windows.Forms.DataGridView dGV3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3_2;
    }
}