namespace AngelLayout
{
    partial class Midow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Midow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.检索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.试图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStartPage = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRegisterInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMain,
            this.检索SToolStripMenuItem,
            this.试图VToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1580, 43);
            this.menuStrip.TabIndex = 37;
            this.menuStrip.Text = "menuStrip";
            // 
            // MenuMain
            // 
            this.MenuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_new,
            this.menuMyFile,
            this.toolStripMenuItem2,
            this.menuQuit});
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(103, 35);
            this.MenuMain.Text = "文件(&F)";
            // 
            // tsm_new
            // 
            this.tsm_new.Name = "tsm_new";
            this.tsm_new.Size = new System.Drawing.Size(237, 38);
            this.tsm_new.Text = "新建(&N)";
            // 
            // menuMyFile
            // 
            this.menuMyFile.Name = "menuMyFile";
            this.menuMyFile.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuMyFile.Size = new System.Drawing.Size(237, 38);
            this.menuMyFile.Text = "打开(&O)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(234, 6);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(237, 38);
            this.menuQuit.Text = "退出(&Q)";
            // 
            // 检索SToolStripMenuItem
            // 
            this.检索SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSearch,
            this.menuHistory});
            this.检索SToolStripMenuItem.Name = "检索SToolStripMenuItem";
            this.检索SToolStripMenuItem.Size = new System.Drawing.Size(104, 35);
            this.检索SToolStripMenuItem.Text = "检索(&S)";
            // 
            // menuSearch
            // 
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSearch.Size = new System.Drawing.Size(256, 38);
            this.menuSearch.Text = "检索";
            // 
            // menuHistory
            // 
            this.menuHistory.Name = "menuHistory";
            this.menuHistory.Size = new System.Drawing.Size(256, 38);
            this.menuHistory.Text = "检索历史记录";
            // 
            // 试图VToolStripMenuItem
            // 
            this.试图VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStartPage});
            this.试图VToolStripMenuItem.Name = "试图VToolStripMenuItem";
            this.试图VToolStripMenuItem.Size = new System.Drawing.Size(106, 35);
            this.试图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // menuStartPage
            // 
            this.menuStartPage.Name = "menuStartPage";
            this.menuStartPage.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuStartPage.Size = new System.Drawing.Size(225, 38);
            this.menuStartPage.Text = "起始页";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettings,
            this.menuBackup,
            this.menuRestore});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(104, 35);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(196, 38);
            this.menuSettings.Text = "配置(&O)";
            // 
            // menuBackup
            // 
            this.menuBackup.Name = "menuBackup";
            this.menuBackup.Size = new System.Drawing.Size(196, 38);
            this.menuBackup.Text = "备份(&B)";
            // 
            // menuRestore
            // 
            this.menuRestore.Name = "menuRestore";
            this.menuRestore.Size = new System.Drawing.Size(196, 38);
            this.menuRestore.Text = "还原";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelp,
            this.toolStripMenuItem1,
            this.menuRegisterInfo});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(109, 35);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(243, 38);
            this.menuHelp.Text = "查看帮助(&H)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(240, 6);
            // 
            // menuRegisterInfo
            // 
            this.menuRegisterInfo.Name = "menuRegisterInfo";
            this.menuRegisterInfo.Size = new System.Drawing.Size(243, 38);
            this.menuRegisterInfo.Text = "关于(&A)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1090);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1580, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 43);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1580, 25);
            this.toolStrip1.TabIndex = 40;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(0, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1580, 1022);
            this.textBox1.TabIndex = 41;
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1302, 260);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 35);
            this.textBox2.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SlateBlue;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(1302, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 34);
            this.label3.TabIndex = 44;
            this.label3.Text = "R2.ColorRibbon";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(1302, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "R1.ColorRibbon";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("黑体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(590, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(934, 732);
            this.label2.TabIndex = 43;
            this.label2.Text = "https://www.it610.com/article/4690776.htm";
            this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.label2_Paint);
            this.label2.Validating += new System.ComponentModel.CancelEventHandler(this.label2_Validating);
            // 
            // Midow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 1112);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Midow";
            this.Text = "[Asnick]wjcking";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuMain;
        private System.Windows.Forms.ToolStripMenuItem menuMyFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem 检索SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSearch;
        private System.Windows.Forms.ToolStripMenuItem menuHistory;
        private System.Windows.Forms.ToolStripMenuItem 试图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStartPage;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuBackup;
        private System.Windows.Forms.ToolStripMenuItem menuRestore;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuRegisterInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_new;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}