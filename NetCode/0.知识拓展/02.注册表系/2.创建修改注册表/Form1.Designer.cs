using System;

namespace _2.创建修改注册表
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
            this.components = new System.ComponentModel.Container();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearlog = new System.Windows.Forms.ToolStripMenuItem();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxt
            // 
            this.rtxt.ContextMenuStrip = this.contextMenuStrip1;
            this.rtxt.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxt.Location = new System.Drawing.Point(-6, 97);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(899, 311);
            this.rtxt.TabIndex = 3;
            this.rtxt.Text = "";
            this.rtxt.TextChanged += new System.EventHandler(this.rtxt_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearlog});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // clearlog
            // 
            this.clearlog.Name = "clearlog";
            this.clearlog.Size = new System.Drawing.Size(124, 22);
            this.clearlog.Text = "清空日记";
            this.clearlog.Click += new System.EventHandler(this.clearlog_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(37, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(165, 67);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "读取 dnt";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.Location = new System.Drawing.Point(245, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(165, 67);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "创建 dnt";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4.Location = new System.Drawing.Point(652, 12);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(165, 67);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "删除 dnt";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.Location = new System.Drawing.Point(443, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(165, 67);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "修改 dnt";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 412);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.btn2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }             

        #endregion

        private System.Windows.Forms.RichTextBox rtxt;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearlog;
    }
}

