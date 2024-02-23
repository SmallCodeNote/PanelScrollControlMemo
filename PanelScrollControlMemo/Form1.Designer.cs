namespace PanelScrollControlMemo
{
    partial class Form1
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
            this.panel_Frame = new System.Windows.Forms.Panel();
            this.panel_Contents = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label_vValue = new System.Windows.Forms.Label();
            this.label_hValue = new System.Windows.Forms.Label();
            this.panel_Frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Frame
            // 
            this.panel_Frame.Controls.Add(this.panel_Contents);
            this.panel_Frame.Location = new System.Drawing.Point(26, 29);
            this.panel_Frame.Name = "panel_Frame";
            this.panel_Frame.Size = new System.Drawing.Size(500, 500);
            this.panel_Frame.TabIndex = 0;
            // 
            // panel_Contents
            // 
            this.panel_Contents.Location = new System.Drawing.Point(0, 0);
            this.panel_Contents.Name = "panel_Contents";
            this.panel_Contents.Size = new System.Drawing.Size(200, 100);
            this.panel_Contents.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(533, 32);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 493);
            this.vScrollBar1.TabIndex = 1;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(27, 537);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(499, 20);
            this.hScrollBar1.TabIndex = 2;
            // 
            // label_vValue
            // 
            this.label_vValue.AutoSize = true;
            this.label_vValue.Location = new System.Drawing.Point(560, 502);
            this.label_vValue.Name = "label_vValue";
            this.label_vValue.Size = new System.Drawing.Size(35, 12);
            this.label_vValue.TabIndex = 3;
            this.label_vValue.Text = "label1";
            // 
            // label_hValue
            // 
            this.label_hValue.AutoSize = true;
            this.label_hValue.Location = new System.Drawing.Point(543, 545);
            this.label_hValue.Name = "label_hValue";
            this.label_hValue.Size = new System.Drawing.Size(35, 12);
            this.label_hValue.TabIndex = 3;
            this.label_hValue.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 566);
            this.Controls.Add(this.label_hValue);
            this.Controls.Add(this.label_vValue);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panel_Frame);
            this.Name = "Form1";
            this.Text = "PanelScrollControlMemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Frame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Frame;
        private System.Windows.Forms.Panel panel_Contents;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label_vValue;
        private System.Windows.Forms.Label label_hValue;
    }
}

