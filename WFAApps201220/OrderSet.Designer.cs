namespace WFAApps201220
{
    partial class OrderSet
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
            this.tbBefore = new System.Windows.Forms.TextBox();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOrderASC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBefore
            // 
            this.tbBefore.Location = new System.Drawing.Point(53, 43);
            this.tbBefore.Name = "tbBefore";
            this.tbBefore.Size = new System.Drawing.Size(245, 19);
            this.tbBefore.TabIndex = 0;
            this.tbBefore.TextChanged += new System.EventHandler(this.tbBefore_TextChanged);
            // 
            // tbAfter
            // 
            this.tbAfter.Location = new System.Drawing.Point(53, 68);
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.Size = new System.Drawing.Size(245, 19);
            this.tbAfter.TabIndex = 0;
            this.tbAfter.TextChanged += new System.EventHandler(this.tbAfter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "並替前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "並替後";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(14, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "メインへ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOrderASC
            // 
            this.btnOrderASC.Location = new System.Drawing.Point(118, 4);
            this.btnOrderASC.Name = "btnOrderASC";
            this.btnOrderASC.Size = new System.Drawing.Size(90, 33);
            this.btnOrderASC.TabIndex = 4;
            this.btnOrderASC.Text = "昇順並べ替え";
            this.btnOrderASC.UseVisualStyleBackColor = true;
            this.btnOrderASC.Click += new System.EventHandler(this.btnOrderASC_Click);
            // 
            // OrderSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 95);
            this.Controls.Add(this.btnOrderASC);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAfter);
            this.Controls.Add(this.tbBefore);
            this.Name = "OrderSet";
            this.Text = "並べかえ";
            this.Load += new System.EventHandler(this.OrderSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBefore;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOrderASC;
    }
}