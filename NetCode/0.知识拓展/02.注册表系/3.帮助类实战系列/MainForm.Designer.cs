namespace _3.帮助类实战系列
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(37, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(461, 67);
            this.button1.TabIndex = 15;
            this.button1.Text = "恢复鼠标右击菜单";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn3.Location = new System.Drawing.Point(37, 194);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(461, 67);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "桌面显示 我的电脑";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn2.Location = new System.Drawing.Point(37, 100);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(461, 67);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "桌面隐藏 我的电脑";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn1.Location = new System.Drawing.Point(37, 14);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(461, 67);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "DNT Helper 演示系列";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn4.Location = new System.Drawing.Point(37, 287);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(461, 67);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "禁用鼠标右击菜单";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(557, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日常使用";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
    }
}