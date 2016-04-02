namespace BFR.WinApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusToolBar = new System.Windows.Forms.StatusStrip();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FilesList = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbBak = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.nudBit = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbConnector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbReName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbReplaceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReplacedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(77, 17);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFiles.TabIndex = 5;
            this.btnSelectFiles.Text = "浏览";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择文件:";
            // 
            // StatusToolBar
            // 
            this.StatusToolBar.Location = new System.Drawing.Point(0, 371);
            this.StatusToolBar.Name = "StatusToolBar";
            this.StatusToolBar.ShowItemToolTips = true;
            this.StatusToolBar.Size = new System.Drawing.Size(627, 22);
            this.StatusToolBar.SizingGrip = false;
            this.StatusToolBar.TabIndex = 5;
            this.StatusToolBar.Text = "状态栏";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FilesList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 371);
            this.panel3.TabIndex = 8;
            // 
            // FilesList
            // 
            this.FilesList.BackColor = System.Drawing.SystemColors.Window;
            this.FilesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.FullName});
            this.FilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesList.FullRowSelect = true;
            this.FilesList.GridLines = true;
            this.FilesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FilesList.HideSelection = false;
            this.FilesList.Location = new System.Drawing.Point(0, 0);
            this.FilesList.Name = "FilesList";
            this.FilesList.ShowItemToolTips = true;
            this.FilesList.Size = new System.Drawing.Size(378, 371);
            this.FilesList.TabIndex = 4;
            this.FilesList.UseCompatibleStateImageBehavior = false;
            this.FilesList.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "序号";
            this.No.Width = 45;
            // 
            // FullName
            // 
            this.FullName.Text = "文件";
            this.FullName.Width = 325;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbBak);
            this.panel2.Controls.Add(this.btnSelectFiles);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(378, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 371);
            this.panel2.TabIndex = 7;
            // 
            // cbBak
            // 
            this.cbBak.AutoSize = true;
            this.cbBak.Location = new System.Drawing.Point(159, 21);
            this.cbBak.Name = "cbBak";
            this.cbBak.Size = new System.Drawing.Size(84, 16);
            this.cbBak.TabIndex = 6;
            this.cbBak.Text = "备份原文件";
            this.cbBak.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudStart);
            this.groupBox2.Controls.Add(this.nudBit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbConnector);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbReName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "序号";
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(166, 75);
            this.nudStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(50, 21);
            this.nudStart.TabIndex = 7;
            this.nudStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudBit
            // 
            this.nudBit.Location = new System.Drawing.Point(72, 75);
            this.nudBit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBit.Name = "nudBit";
            this.nudBit.Size = new System.Drawing.Size(33, 21);
            this.nudBit.TabIndex = 7;
            this.nudBit.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "开始序号:";
            // 
            // tbConnector
            // 
            this.tbConnector.Location = new System.Drawing.Point(72, 47);
            this.tbConnector.Name = "tbConnector";
            this.tbConnector.Size = new System.Drawing.Size(146, 21);
            this.tbConnector.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "序号位数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "连接符号:";
            // 
            // tbReName
            // 
            this.tbReName.Location = new System.Drawing.Point(72, 20);
            this.tbReName.Name = "tbReName";
            this.tbReName.Size = new System.Drawing.Size(146, 21);
            this.tbReName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "重新命名:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbReplaceText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbReplacedText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "替换";
            // 
            // tbReplaceText
            // 
            this.tbReplaceText.Location = new System.Drawing.Point(72, 47);
            this.tbReplaceText.Name = "tbReplaceText";
            this.tbReplaceText.Size = new System.Drawing.Size(146, 21);
            this.tbReplaceText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "替换内容:";
            // 
            // tbReplacedText
            // 
            this.tbReplacedText.Location = new System.Drawing.Point(72, 20);
            this.tbReplacedText.Name = "tbReplacedText";
            this.tbReplacedText.Size = new System.Drawing.Size(146, 21);
            this.tbReplacedText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "被替内容:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(77, 272);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 51);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg.Location = new System.Drawing.Point(2, 376);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(29, 12);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Text = "就绪";
            // 
            // lnkAbout
            // 
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkAbout.Location = new System.Drawing.Point(536, 377);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(31, 12);
            this.lnkAbout.TabIndex = 10;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "关于";
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(576, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "v1.0.0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 393);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StatusToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "批量文件重命名工具";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip StatusToolBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView FilesList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbReplaceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReplacedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.CheckBox cbBak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConnector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudBit;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.Label label8;

    }
}

