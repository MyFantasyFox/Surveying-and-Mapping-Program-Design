namespace 电离层改正计算
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电离层数据导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.对流层数据导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算卫星高度角和方位角ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高度角和方位角计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.穿刺点的地磁纬度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.卫星坐标数据 = new System.Windows.Forms.TabControl();
            this.对流层数据 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.卫星坐标数据.SuspendLayout();
            this.对流层数据.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1373, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "时间数据";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1215, 28);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 28);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1010, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 28);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(802, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 28);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(590, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 28);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1159, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(955, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "时";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "年";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据导入ToolStripMenuItem,
            this.计算卫星高度角和方位角ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1398, 32);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据导入ToolStripMenuItem
            // 
            this.数据导入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.电离层数据导入ToolStripMenuItem,
            this.对流层数据导入ToolStripMenuItem});
            this.数据导入ToolStripMenuItem.Name = "数据导入ToolStripMenuItem";
            this.数据导入ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.数据导入ToolStripMenuItem.Text = "数据导入";
            // 
            // 电离层数据导入ToolStripMenuItem
            // 
            this.电离层数据导入ToolStripMenuItem.Name = "电离层数据导入ToolStripMenuItem";
            this.电离层数据导入ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.电离层数据导入ToolStripMenuItem.Text = "电离层数据导入";
            this.电离层数据导入ToolStripMenuItem.Click += new System.EventHandler(this.电离层数据导入ToolStripMenuItem_Click);
            // 
            // 对流层数据导入ToolStripMenuItem
            // 
            this.对流层数据导入ToolStripMenuItem.Name = "对流层数据导入ToolStripMenuItem";
            this.对流层数据导入ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.对流层数据导入ToolStripMenuItem.Text = "对流层数据导入";
            this.对流层数据导入ToolStripMenuItem.Click += new System.EventHandler(this.对流层数据导入ToolStripMenuItem_Click);
            // 
            // 计算卫星高度角和方位角ToolStripMenuItem
            // 
            this.计算卫星高度角和方位角ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.高度角和方位角计算ToolStripMenuItem,
            this.穿刺点的地磁纬度ToolStripMenuItem});
            this.计算卫星高度角和方位角ToolStripMenuItem.Name = "计算卫星高度角和方位角ToolStripMenuItem";
            this.计算卫星高度角和方位角ToolStripMenuItem.Size = new System.Drawing.Size(220, 28);
            this.计算卫星高度角和方位角ToolStripMenuItem.Text = "计算卫星高度角和方位角";
            this.计算卫星高度角和方位角ToolStripMenuItem.Click += new System.EventHandler(this.计算卫星高度角和方位角ToolStripMenuItem_Click);
            // 
            // 高度角和方位角计算ToolStripMenuItem
            // 
            this.高度角和方位角计算ToolStripMenuItem.Name = "高度角和方位角计算ToolStripMenuItem";
            this.高度角和方位角计算ToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.高度角和方位角计算ToolStripMenuItem.Text = "高度角和方位角计算";
            this.高度角和方位角计算ToolStripMenuItem.Click += new System.EventHandler(this.高度角和方位角计算ToolStripMenuItem_Click);
            // 
            // 穿刺点的地磁纬度ToolStripMenuItem
            // 
            this.穿刺点的地磁纬度ToolStripMenuItem.Name = "穿刺点的地磁纬度ToolStripMenuItem";
            this.穿刺点的地磁纬度ToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.穿刺点的地磁纬度ToolStripMenuItem.Text = "穿刺点的地磁纬度";
            this.穿刺点的地磁纬度ToolStripMenuItem.Click += new System.EventHandler(this.穿刺点的地磁纬度ToolStripMenuItem_Click_1);
            // 
            // 卫星坐标数据
            // 
            this.卫星坐标数据.Controls.Add(this.对流层数据);
            this.卫星坐标数据.Controls.Add(this.tabPage2);
            this.卫星坐标数据.Controls.Add(this.tabPage1);
            this.卫星坐标数据.Location = new System.Drawing.Point(13, 148);
            this.卫星坐标数据.Name = "卫星坐标数据";
            this.卫星坐标数据.SelectedIndex = 0;
            this.卫星坐标数据.Size = new System.Drawing.Size(1373, 586);
            this.卫星坐标数据.TabIndex = 3;
            // 
            // 对流层数据
            // 
            this.对流层数据.Controls.Add(this.dataGridView1);
            this.对流层数据.Location = new System.Drawing.Point(4, 28);
            this.对流层数据.Name = "对流层数据";
            this.对流层数据.Padding = new System.Windows.Forms.Padding(3);
            this.对流层数据.Size = new System.Drawing.Size(1365, 554);
            this.对流层数据.TabIndex = 0;
            this.对流层数据.Text = "对流层数据";
            this.对流层数据.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1350, 541);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1365, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "电离层数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(1350, 541);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1365, 554);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "报告";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(4, 7);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(1355, 541);
            this.textBox7.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 746);
            this.Controls.Add(this.卫星坐标数据);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.卫星坐标数据.ResumeLayout(false);
            this.对流层数据.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl 卫星坐标数据;
        private System.Windows.Forms.TabPage 对流层数据;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 数据导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电离层数据导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 对流层数据导入ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 计算卫星高度角和方位角ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高度角和方位角计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 穿刺点的地磁纬度ToolStripMenuItem;
    }
}

