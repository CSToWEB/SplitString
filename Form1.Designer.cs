namespace StringOperate
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.分割字符串ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清除文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清除text1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清除text2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.绘图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.分割字符串ToolStripMenuItem,
            this.清除文本ToolStripMenuItem,
            this.绘图ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(640, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 打开ToolStripMenuItem
			// 
			this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
			this.打开ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.打开ToolStripMenuItem.Text = "打开";
			this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
			// 
			// 分割字符串ToolStripMenuItem
			// 
			this.分割字符串ToolStripMenuItem.Name = "分割字符串ToolStripMenuItem";
			this.分割字符串ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
			this.分割字符串ToolStripMenuItem.Text = "分割字符串";
			this.分割字符串ToolStripMenuItem.Click += new System.EventHandler(this.分割字符串ToolStripMenuItem_Click);
			// 
			// 清除文本ToolStripMenuItem
			// 
			this.清除文本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除text1ToolStripMenuItem,
            this.清除text2ToolStripMenuItem});
			this.清除文本ToolStripMenuItem.Name = "清除文本ToolStripMenuItem";
			this.清除文本ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
			this.清除文本ToolStripMenuItem.Text = "清除文本";
			// 
			// 清除text1ToolStripMenuItem
			// 
			this.清除text1ToolStripMenuItem.Name = "清除text1ToolStripMenuItem";
			this.清除text1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.清除text1ToolStripMenuItem.Text = "清空text1内容";
			this.清除text1ToolStripMenuItem.Click += new System.EventHandler(this.清除text1ToolStripMenuItem_Click);
			// 
			// 清除text2ToolStripMenuItem
			// 
			this.清除text2ToolStripMenuItem.Name = "清除text2ToolStripMenuItem";
			this.清除text2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.清除text2ToolStripMenuItem.Text = "清空text2内容";
			this.清除text2ToolStripMenuItem.Click += new System.EventHandler(this.清除text2ToolStripMenuItem_Click);
			// 
			// 保存ToolStripMenuItem
			// 
			this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
			this.保存ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.保存ToolStripMenuItem.Text = "保存";
			this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
			// 
			// 帮助ToolStripMenuItem
			// 
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.帮助ToolStripMenuItem.Text = "帮助";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(5, 30);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(308, 274);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(319, 30);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(308, 274);
			this.textBox2.TabIndex = 2;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Multiselect = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.statusStrip1.Location = new System.Drawing.Point(0, 309);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(640, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// 绘图ToolStripMenuItem
			// 
			this.绘图ToolStripMenuItem.Name = "绘图ToolStripMenuItem";
			this.绘图ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.绘图ToolStripMenuItem.Text = "绘图";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 331);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "操作字符串";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分割字符串ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除text1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除text2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem 绘图ToolStripMenuItem;
	}
}

