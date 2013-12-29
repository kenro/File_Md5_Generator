namespace FileMd5Gen
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.choosePath = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.ListBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choosePath
            // 
            this.choosePath.Location = new System.Drawing.Point(89, 40);
            this.choosePath.Name = "choosePath";
            this.choosePath.Size = new System.Drawing.Size(198, 21);
            this.choosePath.TabIndex = 0;
            // 
            // info
            // 
            this.info.FormattingEnabled = true;
            this.info.ItemHeight = 12;
            this.info.Location = new System.Drawing.Point(89, 75);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(554, 280);
            this.info.TabIndex = 1;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(349, 37);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "选择目录";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(324, 373);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 3;
            this.btnGen.Text = "生成";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 408);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.info);
            this.Controls.Add(this.choosePath);
            this.Name = "Form1";
            this.Text = " 文件Md5生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox choosePath;
        private System.Windows.Forms.ListBox info;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnGen;
    }
}

