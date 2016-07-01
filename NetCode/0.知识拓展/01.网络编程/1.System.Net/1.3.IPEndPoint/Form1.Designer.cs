namespace _1._3.IPEndPoint
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUrl.Location = new System.Drawing.Point(17, 27);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(160, 29);
            this.txtUrl.TabIndex = 8;
            this.txtUrl.Text = "192.168.0.1";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(199, 23);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(130, 36);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "获取 IP 信息";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 87);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btn1;
    }
}

