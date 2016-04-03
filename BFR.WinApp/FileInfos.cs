using System;
using System.Collections.Generic;
using System.Text;

namespace BFR.WinApp
{
    /// <summary>
    /// 文件信息类
    /// </summary>
    public class FileInfos
    {
        /// <summary>
        /// 文件路径,以\结尾
        /// </summary>
        public string Dir { get; set; }

        /// <summary>
        /// 文件名,包含路径和扩展名
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 安全文件名,不包含路径和扩展名
        /// </summary>
        public string SafeName { get; set; }

        /// <summary>
        /// 文件名,不包含路径
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 扩展名
        /// </summary>
        public string Ext { get; set; }

        public FileInfos() { }

        /// <summary>
        /// 文件信息类
        /// </summary>
        /// <param name="fullname">包含路径的文件</param>
        public FileInfos(string fullname)
        {
            string dir = fullname.Remove(fullname.LastIndexOf("\\") + 1);
            string name = fullname.Replace(dir, "");
            string ext = name.Substring(name.LastIndexOf("."));
            string safe = name.Replace(ext, "");

            this.Dir = dir;
            this.FullName = fullname;
            this.Name = name;
            this.SafeName = safe;
            this.Ext = ext;
        }

        /// <summary>
        /// 文件信息类
        /// </summary>
        /// <param name="dir">文件所在的目录</param>
        /// <param name="name">文件名称,包含扩展名</param>
        public FileInfos(string dir,string name)
        {
            if (!dir.EndsWith("\\"))
            {
                dir += "\\";
            }
            string ext = name.Substring(name.LastIndexOf("."));
            string safe = name.Replace(ext, "");

            this.Dir = dir;
            this.FullName = dir+name;
            this.Name = name;
            this.SafeName = safe;
            this.Ext = ext;
        }
    }
}
