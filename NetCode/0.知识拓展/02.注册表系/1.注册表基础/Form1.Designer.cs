namespace _1.注册表基础
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.rtxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(269, 7);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(317, 51);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "遍历 software 子项";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // rtxt
            // 
            this.rtxt.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxt.Location = new System.Drawing.Point(5, 69);
            this.rtxt.Name = "rtxt";
            this.rtxt.Size = new System.Drawing.Size(899, 348);
            this.rtxt.TabIndex = 1;
            this.rtxt.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 429);
            this.Controls.Add(this.rtxt);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.RichTextBox rtxt;
    }
}