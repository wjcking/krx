namespace AngelLayout
{
    partial class Rabber
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
            this.ketub1 = new AngelLayout.Ketub();
            this.SuspendLayout();
            // 
            // ketub1
            // 
            this.ketub1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ketub1.CustomAutoSize = true;
            this.ketub1.EmptyTextTip = null;
            this.ketub1.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.ketub1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ketub1.Location = new System.Drawing.Point(21, 21);
            this.ketub1.Multiline = true;
            this.ketub1.Name = "ketub1";
            this.ketub1.Radius = 12;
            this.ketub1.Size = new System.Drawing.Size(483, 382);
            this.ketub1.TabIndex = 0;
            // 
            // Rabber
            // 
            this.ClientSize = new System.Drawing.Size(559, 457);
            this.Controls.Add(this.ketub1);
            this.Name = "Rabber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AngelLayout  .Ketub ketub1;
    }
}

