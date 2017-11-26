namespace _88142725tmz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msmain = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ostmain = new System.Windows.Forms.ToolStripMenuItem();
            this.ctsmain = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpmain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmain = new System.Windows.Forms.ToolStrip();
            this.ofdmain = new System.Windows.Forms.OpenFileDialog();
            this.pb = new System.Windows.Forms.PictureBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt3 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsl = new System.Windows.Forms.ToolStripLabel();
            this.msmain.SuspendLayout();
            this.tsmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // msmain
            // 
            this.msmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.msmain.Location = new System.Drawing.Point(0, 0);
            this.msmain.Name = "msmain";
            this.msmain.Size = new System.Drawing.Size(1916, 25);
            this.msmain.TabIndex = 0;
            this.msmain.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ostmain,
            this.ctsmain});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // ostmain
            // 
            this.ostmain.Name = "ostmain";
            this.ostmain.Size = new System.Drawing.Size(152, 22);
            this.ostmain.Text = "打开";
            this.ostmain.Click += new System.EventHandler(this.ostmain_Click);
            // 
            // ctsmain
            // 
            this.ctsmain.Name = "ctsmain";
            this.ctsmain.Size = new System.Drawing.Size(152, 22);
            this.ctsmain.Text = "关闭";
            this.ctsmain.Click += new System.EventHandler(this.ctsmain_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpmain});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // helpmain
            // 
            this.helpmain.Name = "helpmain";
            this.helpmain.Size = new System.Drawing.Size(152, 22);
            this.helpmain.Text = "使用说明";
            this.helpmain.Click += new System.EventHandler(this.helpmain_Click);
            // 
            // tsmain
            // 
            this.tsmain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl});
            this.tsmain.Location = new System.Drawing.Point(0, 1028);
            this.tsmain.Name = "tsmain";
            this.tsmain.Size = new System.Drawing.Size(1916, 25);
            this.tsmain.TabIndex = 1;
            this.tsmain.Text = "toolStrip1";
            // 
            // ofdmain
            // 
            this.ofdmain.FileName = "openFileDialog1";
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.White;
            this.pb.Location = new System.Drawing.Point(125, 125);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(800, 600);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 3;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(600, 800);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 30);
            this.bt1.TabIndex = 4;
            this.bt1.Text = "检测";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(758, 800);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 30);
            this.bt2.TabIndex = 5;
            this.bt2.Text = "本地打开";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(125, 800);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "请输入网络图片URL";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(703, 804);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "或";
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(125, 854);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 30);
            this.bt3.TabIndex = 8;
            this.bt3.Text = "清空";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(1222, 125);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(365, 98);
            this.txtResult.TabIndex = 9;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // tsl
            // 
            this.tsl.Name = "tsl";
            this.tsl.Size = new System.Drawing.Size(112, 22);
            this.tsl.Text = "2017/6/9 00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1916, 1053);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.tsmain);
            this.Controls.Add(this.msmain);
            this.MainMenuStrip = this.msmain;
            this.Name = "Form1";
            this.Text = "暴恐识别";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msmain.ResumeLayout(false);
            this.msmain.PerformLayout();
            this.tsmain.ResumeLayout(false);
            this.tsmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msmain;
        private System.Windows.Forms.ToolStrip tsmain;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ostmain;
        private System.Windows.Forms.ToolStripMenuItem ctsmain;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpmain;
        private System.Windows.Forms.OpenFileDialog ofdmain;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel tsl;
    }
}

