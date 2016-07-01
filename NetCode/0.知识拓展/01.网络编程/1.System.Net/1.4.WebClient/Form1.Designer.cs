namespace _1._4.WebClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.RichTextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUrl.Location = new System.Drawing.Point(9, 11);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(160, 29);
            this.txtUrl.TabIndex = 6;
            this.txtUrl.Text = "www.baidu.com";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(174, 6);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(76, 36);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "获取内容1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(254, 6);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 36);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "获取内容2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(9, 49);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(395, 134);
            this.txt1.TabIndex = 8;
            this.txt1.Text = "";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(334, 6);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 36);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "下载内容";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 192);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.RichTextBox txt1;
        private System.Windows.Forms.Button btn3;
    }
}

