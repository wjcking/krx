namespace AngelLayout
{
    partial class Komet
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(613, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 322);
            this.label1.TabIndex = 58;
            // 
            // listBox3
            // 
            this.listBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 14;
            this.listBox3.Items.AddRange(new object[] {
            "A3",
            "B1",
            "d4",
            "D5",
            "E6",
            "6v",
            "G",
            "H",
            "J",
            "KE",
            "W",
            "W3",
            "3F",
            "G",
            "E",
            "MV",
            "V",
            "C",
            "Z",
            "A",
            "E",
            "E",
            "R",
            "T",
            "R",
            "W",
            "R"});
            this.listBox3.Location = new System.Drawing.Point(27, 49);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(154, 392);
            this.listBox3.TabIndex = 57;
            // 
            // Komet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(694, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Name = "Komet";
            this.Load += new System.EventHandler(this.Komet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox3;
    }
}
