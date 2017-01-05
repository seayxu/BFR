using BFR.WinApp.ControlInvoke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BFR.WinApp
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 文件列表
        /// </summary>
        List<FileInfos> _files;
        /// <summary>
        /// 根目录
        /// </summary>
        string _dir;
        /// <summary>
        /// 创建时间
        /// </summary>
        DateTime? _createTime;
        /// <summary>
        /// 修改时间
        /// </summary>
        DateTime? _modifiedTime;
        public FrmMain()
        {
            InitializeComponent();
            this.btnStart.Click+=btnStart_Click;
            this.btnSelectFiles.Click += btnSelectFiles_Click;
            this.dtpCreateTime.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.tbCreateTime.Leave += new System.EventHandler(this.TextBoxTime_Leave);
            this.dtpModifiedTime.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            this.tbModifiedTime.Leave += new System.EventHandler(this.TextBoxTime_Leave);
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            this.rbtnLower.Click += new System.EventHandler(this.rbtn_Click);
            this.rbtnUpper.Click += new System.EventHandler(this.rbtn_Click);

            this.lblMsg.Text = "就绪";
            this.tbCreateTime.Text = "";
            this.tbModifiedTime.Text = "";
            this.progressBar1.Visible = false;
            this.rbtnLower.AutoCheck = false;
            this.rbtnUpper.AutoCheck = false;
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            this.lblVersion.Text = string.Format("v{0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }

        /// <summary>
        /// 选择文件按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            this.FilesList.Items.Clear();
            _files = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Yes || result == DialogResult.OK)
            {
                _dir = GetFileDir(dialog.FileName);
                _files = new List<FileInfos>();

                foreach (var item in dialog.FileNames)
                {
                    _files.Add(new FileInfos(item));
                }

                Msg("已选择" + _files.Count + "个文件");
                FilesListInit();
            }
            else
            {
                Msg("未选择文件");
            }
        }

        /// <summary>
        /// 开始执行按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                int progress = 1;
                this.TextBoxTime_Leave(this.tbCreateTime, null);
                this.TextBoxTime_Leave(this.tbModifiedTime, null);
                SetProgressBarVisible(true);
                UpdateProgressBar(0, 0, 0);

                if (this._files == null || this._dir == null)
                {
                    Msg("未选择文件");
                    return;
                }

                if (string.IsNullOrEmpty(this.tbReplacedText.Text.Trim()) &&
                    string.IsNullOrEmpty(this.tbReName.Text.Trim()) &&
                    !this.rbtnLower.Checked && !this.rbtnUpper.Checked &&
                    string.IsNullOrEmpty(this.tbCreateTime.Text) &&
                    string.IsNullOrEmpty(this.tbModifiedTime.Text))
                {
                    Msg("请填写操作参数:替换或者重命名相关信息");
                    return;
                }

                if (this.cbBak.Checked)
                {
                    string tmpPath = _dir + "tmp\\";
                    if (!Directory.Exists(tmpPath))
                    {
                        Directory.CreateDirectory(tmpPath);
                    }

                    foreach (FileInfos file in _files)
                    {
                        Msg("备份中:" + progress + "/" + _files.Count);
                        UpdateProgressBar(progress, 1, _files.Count);
                        File.Copy(_dir + file.Name, tmpPath + file.Name,true);
                        progress++;
                    }
                }

                Msg("重命名中……");
                List<FileInfos> fileList = new List<FileInfos>();

                int counter = 0;

                //0:不修改;1:替换;2:重命名;
                int type = 0;
                progress = 1;
                if (!string.IsNullOrEmpty(this.tbReName.Text.Trim()))
                {
                    type = 2;
                    counter = (int)this.nudStart.Value;
                    var max = Math.Pow(10, (double) this.nudBit.Value) - 1;
                    if (this._files.Count > (max - (int)this.nudStart.Value))
                    {
                        Msg("序号位数最大值小于所选文件数,请更正序号位数");
                        return;
                    }
                }
                else if (!string.IsNullOrEmpty(this.tbReplacedText.Text.Trim()))
                {
                    type = 1;
                }

                bool extUpper = Invokes.GetRadioButtonChecked(this.rbtnUpper);
                bool extLower = Invokes.GetRadioButtonChecked(this.rbtnLower);

                foreach (FileInfos info in _files)
                {
                    string tmp = info.SafeName;
                    if (type == 1)//替换
                    {
                        tmp = info.SafeName.Replace(this.tbReplacedText.Text.Trim(), this.tbReplaceText.Text.Trim());
                    }
                    else if (type == 2)//重命名-序号
                    {
                        tmp = this.tbReName.Text.Trim() +
                            this.tbConnector.Text.Trim() +
                            this.GetSerial(counter, (int)this.nudBit.Value);
                    }

                    if (File.Exists(info.FullName))
                    {
                        Msg("重命名中:" + progress + "/" + _files.Count);
                        UpdateProgressBar(progress, 1, _files.Count);
                        string _ext = info.Ext;
                        if (!string.IsNullOrEmpty(_ext))
                        {
                            if (extUpper)
                            {
                                _ext = _ext.ToUpper();
                            }
                            else if (extLower)
                            {
                                _ext = _ext.ToLower();
                            } 
                        }

                        FileInfos _info = new FileInfos();                        
                        _info.Dir = info.Dir;
                        _info.Ext = _ext;
                        _info.SafeName = tmp;
                        _info.Name = tmp + _ext;
                        _info.FullName = info.Dir + tmp + _ext;
                        fileList.Add(_info);

                        FileInfo file = new FileInfo(info.FullName);
                        if (_createTime != null)
                        {
                            file.CreationTime = (DateTime)_createTime;
                            file.LastAccessTime = (DateTime)_createTime; 
                        }
                        if (_modifiedTime != null)
                        {
                            file.LastWriteTime = (DateTime)_modifiedTime;
                            file.LastAccessTime = (DateTime)_modifiedTime;
                        }
                        file.MoveTo(_info.FullName);
                    }
                    progress++;
                    counter++;
                }
                Msg("重命名完成");
                _files = fileList;
                FilesListInit();
                this.tbReplaceText.Text = "";
                this.tbReplacedText.Text = "";
                this.tbReName.Text = "";
                this.tbConnector.Text = "";
            }
            catch (Exception ex)
            {
                Msg("发生异常");
            }
            finally
            {
                SetProgressBarVisible(false);
                UpdateProgressBar(0, 0, 0);
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// 关于事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lnkAbout.Links[0].LinkData = "https://github.com/seayxu/BFR";
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());    
        }

        /// <summary>
        /// 时间选择控件值改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker time = (DateTimePicker)sender;
            if (time.Name == this.dtpCreateTime.Name)
            {
                Invokes.SetTextBoxText(this.tbCreateTime, this.dtpCreateTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            else
            {
                Invokes.SetTextBoxText(this.tbModifiedTime, this.dtpModifiedTime.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        /// <summary>
        /// 时间修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxTime_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl is TextBox)
            {
                TextBox box = (TextBox)sender;
                if (box.Name == this.tbCreateTime.Name)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(this.tbCreateTime.Text.Trim()))
                        {
                            _createTime = DateTime.Parse(this.tbCreateTime.Text.Trim());
                        }
                    }
                    catch (Exception)
                    {
                        _createTime = null;
                        Msg("创建时间格式不对");
                        Invokes.SetTextBoxText(this.tbCreateTime, "");
                    }
                }
                else
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(this.tbModifiedTime.Text.Trim()))
                        {
                            _modifiedTime = DateTime.Parse(this.tbModifiedTime.Text.Trim());
                        }
                    }
                    catch (Exception)
                    {
                        _modifiedTime = null;
                        Msg("修改时间格式不对");
                        Invokes.SetTextBoxText(this.tbModifiedTime, "");
                    }
                }
            }
        }

        /// <summary>
        /// 单选按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_Click(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            bool check = radio.Checked;
            if (radio.Name==this.rbtnLower.Name)
            {
                Invokes.SetRadioButtonChecked(this.rbtnLower, !check);
                check = Invokes.GetRadioButtonChecked(this.rbtnUpper);
                Invokes.SetRadioButtonChecked(this.rbtnUpper, check ? false : check);
            }
            else
            {
                Invokes.SetRadioButtonChecked(this.rbtnUpper, !check);
                check = Invokes.GetRadioButtonChecked(this.rbtnLower);
                Invokes.SetRadioButtonChecked(this.rbtnLower, check ? false : check);
            }

        }

        /// <summary>
        /// 初始化ListView
        /// </summary>
        public void FilesListInit()
        {
            if (this._files == null || this._files.Count < 1)
            {
                Msg("未选择文件");
                return;
            }
            this.FilesList.Items.Clear();
            int index = 1;
            foreach (FileInfos info in _files)
            {
                ListViewItem item = new ListViewItem(index.ToString());
                item.SubItems.Add(info.Name);
                this.FilesList.Items.Add(item);
                index++;
            }
        }

        /// <summary>
        /// 根据完整路径获取目录
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public string GetFileDir(string filename)
        {
            try
            {
                if (string.IsNullOrEmpty(filename))
                {
                    return null;
                }
                string tmp = filename.Remove(filename.LastIndexOf("\\")+1);
                return tmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 生成指定位数序号字符串
        /// </summary>
        /// <param name="num"></param>
        /// <param name="bit"></param>
        /// <returns></returns>
        public string GetSerial(int num,int bit)
        {
            string str = null;
            if (num.ToString().Length >= bit)
            {
                return num.ToString().Substring(0,bit);
            }

            int count = bit - num.ToString().Length;

            for (int i = 0; i < count; i++)
            {
                str += "0";
            }

            str += num.ToString();

            return str;
        }

        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="info"></param>
        public void Msg(string info)
        {
            Invokes.SetLabelText(this.lblMsg, info);
        }

        /// <summary>
        /// 更新进度条
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void UpdateProgressBar(int value,int min,int max)
        {
            Invokes.SetProgressBarMaxValue(this.progressBar1, max);
            Invokes.SetProgressBarMinValue(this.progressBar1, min);
            Invokes.SetProgressBarValue(this.progressBar1, value);
        }

        /// <summary>
        /// 设置进度条可见
        /// </summary>
        /// <param name="visible"></param>
        public void SetProgressBarVisible(bool visible)
        {
            Invokes.SetControlVisible(this.progressBar1, visible);
        }

        private void lnklblLastedVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lnklblLastedVersion.Links[0].LinkData = "https://github.com/seayxu/BFR/releases/latest";
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        
    }
}
