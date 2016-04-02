using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BFR.WinApp
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 文件列表
        /// </summary>
        List<FileInfo> _files;
        /// <summary>
        /// 根目录
        /// </summary>
        string _dir;
        public FrmMain()
        {
            InitializeComponent();
            Msg("");
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
                _files = new List<FileInfo>();

                foreach (var item in dialog.FileNames)
                {
                    _files.Add(new FileInfo(item));
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
                if (string.IsNullOrEmpty(this.tbReplacedText.Text.Trim()) &&
                    string.IsNullOrEmpty(this.tbReName.Text.Trim()))
                {
                    Msg("请填写操作参数:替换或者重命名相关信息");
                    return;
                }

                if (this._files == null || this._dir == null)
                {
                    Msg("未选择文件");
                    return;
                }

                if (this.cbBak.Checked)
                {
                    Msg("备份中……");
                    string tmpPath = _dir + "tmp\\";
                    if (!Directory.Exists(tmpPath))
                    {
                        Directory.CreateDirectory(tmpPath);
                    }
                    foreach (var name in _files)
                    {
                        File.Copy(_dir + name, tmpPath + name);
                    }
                }

                Msg("重命名中……");
                List<FileInfo> fileList = new List<FileInfo>();

                int counter = 0;

                int type = 0;

                if (!string.IsNullOrEmpty(this.tbReName.Text.Trim()))
                {
                    type = 1;
                    counter = (int)this.nudStart.Value;
                    if (this._files.Count > (this.nudBit.Value * 10 - 1 - this.nudStart.Value))
                    {
                        Msg("序号位数最大值小于所选文件数,请更正序号位数");
                        return;
                    }
                }
                else if (!string.IsNullOrEmpty(this.tbReplacedText.Text.Trim()))
                {
                    type = 0;
                }

                foreach (FileInfo info in _files)
                {
                    string tmp = info.SafeName;
                    if (type == 0)//替换
                    {
                        tmp = info.SafeName.Replace(this.tbReplacedText.Text.Trim(), this.tbReplaceText.Text.Trim());
                    }
                    else if (type == 1)//重命名-序号
                    {
                        tmp = this.tbReName.Text.Trim() +
                            this.tbConnector.Text.Trim() +
                            this.GetSerial(counter, (int)this.nudBit.Value);
                    }

                    if (File.Exists(info.FullName))
                    {
                        FileInfo _info = new FileInfo();
                        _info.Dir = info.Dir;
                        _info.Ext = info.Ext;
                        _info.SafeName = tmp;
                        _info.Name = tmp + info.Ext;
                        _info.FullName = info.Dir + tmp + info.Ext;
                        fileList.Add(_info);
                        File.Move(info.FullName, _info.FullName);
                    }
                    counter++;
                }
                Msg("重命名完成");
                _files = fileList;
                FilesListInit();
            }
            catch (Exception ex)
            {
                Msg("异常");
            }
        }

        /// <summary>
        /// 关于事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lnkAbout.Links[0].LinkData = "https://github.com/SeayXu/BFR";
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());    
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
            foreach (FileInfo info in _files)
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
            this.lblMsg.Text = info;
        }
    }
}
