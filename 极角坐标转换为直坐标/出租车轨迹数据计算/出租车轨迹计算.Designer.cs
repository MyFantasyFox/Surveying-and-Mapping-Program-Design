namespace 出租车轨迹数据计算
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN = new System.Windows.Forms.Button();
            this.BTN1 = new System.Windows.Forms.Button();
            this.TBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN2
            // 
            this.BTN2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN2.Font = new System.Drawing.Font("宋体", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN2.Image = ((System.Drawing.Image)(resources.GetObject("BTN2.Image")));
            this.BTN2.Location = new System.Drawing.Point(12, 12);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(88, 38);
            this.BTN2.TabIndex = 1;
            this.BTN2.Text = "文件读取";
            this.BTN2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN2.UseVisualStyleBackColor = false;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // BTN
            // 
            this.BTN.Font = new System.Drawing.Font("宋体", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN.Image = ((System.Drawing.Image)(resources.GetObject("BTN.Image")));
            this.BTN.Location = new System.Drawing.Point(106, 12);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(84, 36);
            this.BTN.TabIndex = 0;
            this.BTN.Text = "计算";
            this.BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN1
            // 
            this.BTN1.Font = new System.Drawing.Font("宋体", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN1.Image = ((System.Drawing.Image)(resources.GetObject("BTN1.Image")));
            this.BTN1.Location = new System.Drawing.Point(196, 14);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(84, 36);
            this.BTN1.TabIndex = 2;
            this.BTN1.Text = "保存";
            this.BTN1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBox
            // 
            this.TBox.Location = new System.Drawing.Point(13, 57);
            this.TBox.Multiline = true;
            this.TBox.Name = "TBox";
            this.TBox.Size = new System.Drawing.Size(775, 381);
            this.TBox.TabIndex = 3;
            this.TBox.TextChanged += new System.EventHandler(this.TBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBox);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.TextBox TBox;
    }
}

