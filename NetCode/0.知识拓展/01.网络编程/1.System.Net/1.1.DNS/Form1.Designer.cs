namespace _1._1.DNS
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
            this.btn1 = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(194, 27);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(90, 36);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "获取 IP";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUrl.Location = new System.Drawing.Point(12, 31);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(160, 29);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "www.baidu.com";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(12, 78);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(182, 36);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "获取主机名";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(305, 27);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(90, 36);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "获取 DNS";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(221, 78);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(182, 36);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "本机 DNS";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 141);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}

