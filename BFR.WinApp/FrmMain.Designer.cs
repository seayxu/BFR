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
            this.lblMsg = new System.Windows.Forms.Label();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FilesList = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnLower = new System.Windows.Forms.RadioButton();
            this.rbtnUpper = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbModifiedTime = new System.Windows.Forms.TextBox();
            this.dtpModifiedTime = new System.Windows.Forms.DateTimePicker();
            this.tbCreateTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpCreateTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBak = new System.Windows.Forms.CheckBox();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg.Location = new System.Drawing.Point(3, 4);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(29, 12);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Text = "就绪";
            // 
            // lnkAbout
            // 
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkAbout.Location = new System.Drawing.Point(537, 4);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(31, 12);
            this.lnkAbout.TabIndex = 10;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "关于";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(577, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "v1.1.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Controls.Add(this.lnkAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 20);
            this.panel1.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(387, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            this.progressBar1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FilesList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 419);
            this.panel3.TabIndex = 14;
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
            this.FilesList.Size = new System.Drawing.Size(387, 419);
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.cbBak);
            this.panel2.Controls.Add(this.btnSelectFiles);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(387, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 419);
            this.panel2.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnLower);
            this.groupBox4.Controls.Add(this.rbtnUpper);
            this.groupBox4.Location = new System.Drawing.Point(8, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 47);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "扩展名";
            // 
            // rbtnLower
            // 
            this.rbtnLower.AutoSize = true;
            this.rbtnLower.Location = new System.Drawing.Point(123, 20);
            this.rbtnLower.Name = "rbtnLower";
            this.rbtnLower.Size = new System.Drawing.Size(95, 16);
            this.rbtnLower.TabIndex = 0;
            this.rbtnLower.Text = "字母变为小写";
            this.rbtnLower.UseVisualStyleBackColor = true;
            // 
            // rbtnUpper
            // 
            this.rbtnUpper.AutoSize = true;
            this.rbtnUpper.Location = new System.Drawing.Point(9, 20);
            this.rbtnUpper.Name = "rbtnUpper";
            this.rbtnUpper.Size = new System.Drawing.Size(95, 16);
            this.rbtnUpper.TabIndex = 0;
            this.rbtnUpper.Text = "字母变为大写";
            this.rbtnUpper.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbModifiedTime);
            this.groupBox3.Controls.Add(this.dtpModifiedTime);
            this.groupBox3.Controls.Add(this.tbCreateTime);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dtpCreateTime);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(8, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "创建信息";
            // 
            // tbModifiedTime
            // 
            this.tbModifiedTime.Location = new System.Drawing.Point(72, 43);
            this.tbModifiedTime.Name = "tbModifiedTime";
            this.tbModifiedTime.Size = new System.Drawing.Size(129, 21);
            this.tbModifiedTime.TabIndex = 5;
            this.tbModifiedTime.Text = "2016-04-02 23:11:59";
            // 
            // dtpModifiedTime
            // 
            this.dtpModifiedTime.Location = new System.Drawing.Point(200, 43);
            this.dtpModifiedTime.Name = "dtpModifiedTime";
            this.dtpModifiedTime.Size = new System.Drawing.Size(18, 21);
            this.dtpModifiedTime.TabIndex = 7;
            // 
            // tbCreateTime
            // 
            this.tbCreateTime.Location = new System.Drawing.Point(72, 17);
            this.tbCreateTime.Name = "tbCreateTime";
            this.tbCreateTime.Size = new System.Drawing.Size(129, 21);
            this.tbCreateTime.TabIndex = 5;
            this.tbCreateTime.Text = "2016-04-02 23:11:59";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "修改时间:";
            // 
            // dtpCreateTime
            // 
            this.dtpCreateTime.Location = new System.Drawing.Point(200, 17);
            this.dtpCreateTime.Name = "dtpCreateTime";
            this.dtpCreateTime.Size = new System.Drawing.Size(18, 21);
            this.dtpCreateTime.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "创建时间:";
            // 
            // cbBak
            // 
            this.cbBak.AutoSize = true;
            this.cbBak.Location = new System.Drawing.Point(153, 8);
            this.cbBak.Name = "cbBak";
            this.cbBak.Size = new System.Drawing.Size(84, 16);
            this.cbBak.TabIndex = 6;
            this.cbBak.Text = "备份原文件";
            this.cbBak.UseVisualStyleBackColor = true;
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(71, 4);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFiles.TabIndex = 5;
            this.btnSelectFiles.Text = "浏览";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择文件:";
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
            this.groupBox2.Location = new System.Drawing.Point(8, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "序号";
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(168, 74);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 29);
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
            this.btnStart.Location = new System.Drawing.Point(8, 364);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(224, 51);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 439);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "批量文件重命名工具";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView FilesList;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader FullName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCreateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbBak;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.NumericUpDown nudBit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbConnector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbReName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbReplaceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReplacedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DateTimePicker dtpCreateTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnLower;
        private System.Windows.Forms.RadioButton rbtnUpper;
        private System.Windows.Forms.TextBox tbModifiedTime;
        private System.Windows.Forms.DateTimePicker dtpModifiedTime;
        private System.Windows.Forms.Label label10;

    }
}

