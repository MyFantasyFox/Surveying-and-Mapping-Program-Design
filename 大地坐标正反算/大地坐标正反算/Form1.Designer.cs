namespace 大地坐标正反算
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.起始点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.终止点 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.大地线长 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.正算数据导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反算数据导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据反算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报告导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.起始点,
            this.B1,
            this.L1,
            this.A1,
            this.终止点,
            this.B2,
            this.L2,
            this.A2,
            this.大地线长});
            this.dataGridView1.Location = new System.Drawing.Point(-135, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1634, 691);
            this.dataGridView1.TabIndex = 0;
            // 
            // 起始点
            // 
            this.起始点.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.起始点.HeaderText = "起始点";
            this.起始点.Name = "起始点";
            // 
            // B1
            // 
            this.B1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.B1.HeaderText = "B1";
            this.B1.Name = "B1";
            // 
            // L1
            // 
            this.L1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.L1.HeaderText = "L1";
            this.L1.Name = "L1";
            // 
            // A1
            // 
            this.A1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A1.HeaderText = "A1";
            this.A1.Name = "A1";
            // 
            // 终止点
            // 
            this.终止点.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.终止点.HeaderText = "终止点";
            this.终止点.Name = "终止点";
            // 
            // B2
            // 
            this.B2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.B2.HeaderText = "B2";
            this.B2.Name = "B2";
            // 
            // L2
            // 
            this.L2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.L2.HeaderText = "L2";
            this.L2.Name = "L2";
            // 
            // A2
            // 
            this.A2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.A2.HeaderText = "A2";
            this.A2.Name = "A2";
            // 
            // 大地线长
            // 
            this.大地线长.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.大地线长.HeaderText = "大地线长";
            this.大地线长.Name = "大地线长";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.数据计算ToolStripMenuItem,
            this.生成报告ToolStripMenuItem,
            this.报告导出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1519, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.正算数据导入ToolStripMenuItem,
            this.反算数据导入ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 28);
            this.toolStripMenuItem1.Text = "数据导入";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 正算数据导入ToolStripMenuItem
            // 
            this.正算数据导入ToolStripMenuItem.Name = "正算数据导入ToolStripMenuItem";
            this.正算数据导入ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.正算数据导入ToolStripMenuItem.Text = "正算数据导入";
            this.正算数据导入ToolStripMenuItem.Click += new System.EventHandler(this.正算数据导入ToolStripMenuItem_Click);
            // 
            // 反算数据导入ToolStripMenuItem
            // 
            this.反算数据导入ToolStripMenuItem.Name = "反算数据导入ToolStripMenuItem";
            this.反算数据导入ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.反算数据导入ToolStripMenuItem.Text = "反算数据导入";
            this.反算数据导入ToolStripMenuItem.Click += new System.EventHandler(this.反算数据导入ToolStripMenuItem_Click);
            // 
            // 数据计算ToolStripMenuItem
            // 
            this.数据计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据ToolStripMenuItem,
            this.数据反算ToolStripMenuItem});
            this.数据计算ToolStripMenuItem.Name = "数据计算ToolStripMenuItem";
            this.数据计算ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.数据计算ToolStripMenuItem.Text = "数据计算";
            // 
            // 数据ToolStripMenuItem
            // 
            this.数据ToolStripMenuItem.Name = "数据ToolStripMenuItem";
            this.数据ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.数据ToolStripMenuItem.Text = "数据正算";
            this.数据ToolStripMenuItem.Click += new System.EventHandler(this.数据ToolStripMenuItem_Click);
            // 
            // 数据反算ToolStripMenuItem
            // 
            this.数据反算ToolStripMenuItem.Name = "数据反算ToolStripMenuItem";
            this.数据反算ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.数据反算ToolStripMenuItem.Text = "数据反算";
            this.数据反算ToolStripMenuItem.Click += new System.EventHandler(this.数据反算ToolStripMenuItem_Click);
            // 
            // 生成报告ToolStripMenuItem
            // 
            this.生成报告ToolStripMenuItem.Name = "生成报告ToolStripMenuItem";
            this.生成报告ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.生成报告ToolStripMenuItem.Text = "生成报告";
            this.生成报告ToolStripMenuItem.Click += new System.EventHandler(this.生成报告ToolStripMenuItem_Click);
            // 
            // 报告导出ToolStripMenuItem
            // 
            this.报告导出ToolStripMenuItem.Name = "报告导出ToolStripMenuItem";
            this.报告导出ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.报告导出ToolStripMenuItem.Text = "报告导出";
            this.报告导出ToolStripMenuItem.Click += new System.EventHandler(this.报告导出ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1494, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本数据";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1141, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "扁率倒数 1/f";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "椭球短半轴";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "椭球长半轴";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1263, 40);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 28);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(653, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 120);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1507, 726);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1499, 694);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1499, 694);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "报告";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(1484, 684);
            this.textBox4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 849);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 起始点;
        private System.Windows.Forms.DataGridViewTextBoxColumn B1;
        private System.Windows.Forms.DataGridViewTextBoxColumn L1;
        private System.Windows.Forms.DataGridViewTextBoxColumn A1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 终止点;
        private System.Windows.Forms.DataGridViewTextBoxColumn B2;
        private System.Windows.Forms.DataGridViewTextBoxColumn L2;
        private System.Windows.Forms.DataGridViewTextBoxColumn A2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 大地线长;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 正算数据导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反算数据导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据反算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报告导出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox4;
    }
}

