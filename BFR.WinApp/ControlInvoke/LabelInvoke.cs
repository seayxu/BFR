using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BFR.WinApp.ControlInvoke
{
    /// <summary>
    /// LabelInvoke
    /// </summary>
    public class LabelInvoke
    {
        /// <summary>
        /// 获取标签文本委托
        /// </summary>
        /// <param name="Ctrl"></param>
        private delegate string GetLabelTextDelegate(Label Ctrl);
        /// <summary>
        /// 设置标签文本委托
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Text"></param>
        private delegate void SetLabelTextDelegate(Label Ctrl, string Text);

        /// <summary>
        /// 获取标签文本方法
        /// </summary>
        /// <param name="Ctrl"></param>
        private static string GetLabelTextFunc(Label Ctrl)
        {
            return Ctrl.Text;
        }

        /// <summary>
        /// 获取标签文本
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static string GetLabelText(Label Ctrl)
        {
            return (string)Ctrl.Invoke(new GetLabelTextDelegate(GetLabelTextFunc), new object[] { Ctrl });
        }

        /// <summary>
        /// 设置标签文本方法
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Text"></param>
        private static void SetLabelTextFunc(Label Ctrl, string Text)
        {
            Ctrl.Text = Text;
            Ctrl.Refresh();
        }

        /// <summary>
        /// 设置标签文本
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Text"></param>
        public static void SetLabelText(Label Ctrl, string Text)
        {
            Ctrl.Invoke(new SetLabelTextDelegate(SetLabelTextFunc), new object[] { Ctrl, Text });
        }
    }
}
