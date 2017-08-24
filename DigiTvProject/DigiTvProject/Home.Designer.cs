namespace DigiTvProject
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.realtime_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.full_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("宋体", 28F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(114, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "数字电视终端设备统计分析系统";
            // 
            // realtime_button
            // 
            this.realtime_button.BackColor = System.Drawing.Color.Navy;
            this.realtime_button.Font = new System.Drawing.Font("宋体", 15F);
            this.realtime_button.ForeColor = System.Drawing.Color.White;
            this.realtime_button.Location = new System.Drawing.Point(92, 274);
            this.realtime_button.Name = "realtime_button";
            this.realtime_button.Size = new System.Drawing.Size(120, 91);
            this.realtime_button.TabIndex = 1;
            this.realtime_button.Text = "实时统计";
            this.realtime_button.UseVisualStyleBackColor = false;
            this.realtime_button.Click += new System.EventHandler(this.button_realtime_Click);
            // 
            // history_button
            // 
            this.history_button.BackColor = System.Drawing.Color.Navy;
            this.history_button.Font = new System.Drawing.Font("宋体", 15F);
            this.history_button.ForeColor = System.Drawing.Color.White;
            this.history_button.Location = new System.Drawing.Point(253, 274);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(120, 91);
            this.history_button.TabIndex = 1;
            this.history_button.Text = "历史数据";
            this.history_button.UseVisualStyleBackColor = false;
            this.history_button.Click += new System.EventHandler(this.button_history_Click);
            // 
            // full_button
            // 
            this.full_button.BackColor = System.Drawing.Color.Navy;
            this.full_button.Font = new System.Drawing.Font("宋体", 15F);
            this.full_button.ForeColor = System.Drawing.Color.White;
            this.full_button.Location = new System.Drawing.Point(418, 273);
            this.full_button.Name = "full_button";
            this.full_button.Size = new System.Drawing.Size(120, 91);
            this.full_button.TabIndex = 1;
            this.full_button.Text = "宏观统计";
            this.full_button.UseVisualStyleBackColor = false;
            this.full_button.Click += new System.EventHandler(this.button_full_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Navy;
            this.search_button.Font = new System.Drawing.Font("宋体", 15F);
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.Location = new System.Drawing.Point(572, 274);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(120, 91);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "数据查询";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.button_search_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.full_button);
            this.Controls.Add(this.history_button);
            this.Controls.Add(this.realtime_button);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "数字电视终端设备统计分析系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button realtime_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Button full_button;
        private System.Windows.Forms.Button search_button;
    }
}

