using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BFR.WinApp.ControlInvoke
{
    /// <summary>
    /// TextBoxInvoke
    /// </summary>
    public class TextBoxInvoke
    {
        /// <summary>
        /// 获取文本框文本委托
        /// </summary>
        /// <param name="Ctrl"></param>
        private delegate string GetTextBoxTextDelegate(TextBox Ctrl);
        /// <summary>
        /// 设置文本框文本委托
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Text"></param>
        private delegate void SetTextBoxTextDelegate(TextBox Ctrl, string Text);

        /// <summary>
        /// 获取文本框文本方法
        /// </summary>
        /// <param name="Ctrl"></param>
        private static string GetTextBoxTextFunc(TextBox Ctrl)
        {
            return Ctrl.Text;
        }

        /// <summary>
        /// 获取文本框文本
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static string GetTextBoxText(TextBox Ctrl)
        {
            return (string)Ctrl.Invoke(new GetTextBoxTextDelegate(GetTextBoxTextFunc), new object[] { Ctrl });
        }

        /// <summary>
        /// 设置文本框文本方法
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Text"></param>
        private static void SetTextBoxTextFunc(TextBox Ctrl, string Text)
        {
            Ctrl.Text = Text;
            Ctrl.Refresh();
        }

        /// <summary>
        /// 设置文本框文本
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Text"></param>
        public static void SetTextBoxText(TextBox Ctrl, string Text)
        {
            Ctrl.Invoke(new SetTextBoxTextDelegate(SetTextBoxTextFunc), new object[] { Ctrl, Text });
        }
    }
}
