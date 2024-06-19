namespace 激光点云数据的平面分割
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dian = new System.Windows.Forms.ToolStripMenuItem();
            this.点云数据输入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分割计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点云数据栅格化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随机抽样一致RANSAC平面分割ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平面拟合ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.生成报告ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 147);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1335, 567);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1327, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "散点传入";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.H,
            this.X,
            this.Y});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1321, 529);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.name.DefaultCellStyle = dataGridViewCellStyle5;
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // H
            // 
            this.H.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.H.DefaultCellStyle = dataGridViewCellStyle6;
            this.H.HeaderText = "H";
            this.H.Name = "H";
            // 
            // X
            // 
            this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.X.DefaultCellStyle = dataGridViewCellStyle7;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Y.DefaultCellStyle = dataGridViewCellStyle8;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1327, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "报告输出";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1312, 604);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dian,
            this.分割计算ToolStripMenuItem,
            this.生成报告ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1335, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dian
            // 
            this.dian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.点云数据输入ToolStripMenuItem});
            this.dian.Image = global::激光点云数据的平面分割.Properties.Resources.文件导入;
            this.dian.Name = "dian";
            this.dian.Size = new System.Drawing.Size(118, 28);
            this.dian.Text = "点云输入";
            // 
            // 点云数据输入ToolStripMenuItem
            // 
            this.点云数据输入ToolStripMenuItem.Name = "点云数据输入ToolStripMenuItem";
            this.点云数据输入ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.点云数据输入ToolStripMenuItem.Text = "点云数据输入";
            this.点云数据输入ToolStripMenuItem.Click += new System.EventHandler(this.点云数据输入ToolStripMenuItem_Click);
            // 
            // 分割计算ToolStripMenuItem
            // 
            this.分割计算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.点云数据栅格化ToolStripMenuItem,
            this.计算ToolStripMenuItem,
            this.随机抽样一致RANSAC平面分割ToolStripMenuItem});
            this.分割计算ToolStripMenuItem.Image = global::激光点云数据的平面分割.Properties.Resources.jisuan;
            this.分割计算ToolStripMenuItem.Name = "分割计算ToolStripMenuItem";
            this.分割计算ToolStripMenuItem.Size = new System.Drawing.Size(118, 28);
            this.分割计算ToolStripMenuItem.Text = "分割计算";
            // 
            // 点云数据栅格化ToolStripMenuItem
            // 
            this.点云数据栅格化ToolStripMenuItem.Name = "点云数据栅格化ToolStripMenuItem";
            this.点云数据栅格化ToolStripMenuItem.Size = new System.Drawing.Size(383, 30);
            this.点云数据栅格化ToolStripMenuItem.Text = "点云数据栅格化";
            this.点云数据栅格化ToolStripMenuItem.Click += new System.EventHandler(this.点云数据栅格化ToolStripMenuItem_Click);
            // 
            // 计算ToolStripMenuItem
            // 
            this.计算ToolStripMenuItem.Name = "计算ToolStripMenuItem";
            this.计算ToolStripMenuItem.Size = new System.Drawing.Size(383, 30);
            this.计算ToolStripMenuItem.Text = "计算栅格单元的几何特征信息";
            this.计算ToolStripMenuItem.Click += new System.EventHandler(this.计算ToolStripMenuItem_Click);
            // 
            // 随机抽样一致RANSAC平面分割ToolStripMenuItem
            // 
            this.随机抽样一致RANSAC平面分割ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.平面拟合ToolStripMenuItem});
            this.随机抽样一致RANSAC平面分割ToolStripMenuItem.Name = "随机抽样一致RANSAC平面分割ToolStripMenuItem";
            this.随机抽样一致RANSAC平面分割ToolStripMenuItem.Size = new System.Drawing.Size(383, 30);
            this.随机抽样一致RANSAC平面分割ToolStripMenuItem.Text = "随机抽样一致（RANSAC）平面分割";
            this.随机抽样一致RANSAC平面分割ToolStripMenuItem.Click += new System.EventHandler(this.随机抽样一致RANSAC平面分割ToolStripMenuItem_Click);
            // 
            // 平面拟合ToolStripMenuItem
            // 
            this.平面拟合ToolStripMenuItem.Name = "平面拟合ToolStripMenuItem";
            this.平面拟合ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.平面拟合ToolStripMenuItem.Text = "平面拟合";
            this.平面拟合ToolStripMenuItem.Click += new System.EventHandler(this.平面拟合ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1316, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "点云总数";
            // 
            // 生成报告ToolStripMenuItem
            // 
            this.生成报告ToolStripMenuItem.Name = "生成报告ToolStripMenuItem";
            this.生成报告ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.生成报告ToolStripMenuItem.Text = "生成报告";
            this.生成报告ToolStripMenuItem.Click += new System.EventHandler(this.生成报告ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 713);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dian;
        private System.Windows.Forms.ToolStripMenuItem 点云数据输入ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem 分割计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点云数据栅格化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 随机抽样一致RANSAC平面分割ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平面拟合ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成报告ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
    }
}

