using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BFR.WinApp.ControlInvoke
{
    /// <summary>
    /// CheckBoxInvoke
    /// </summary>
    public class CheckBoxInvoke
    {
        /// <summary>
        /// 获取选择按钮选中状态委托
        /// </summary>
        /// <param name="Ctrl"></param>
        private delegate bool GetCheckBoxCheckedDelegate(CheckBox Ctrl);
        /// <summary>
        /// 设置选择按钮选中状态委托
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Checked"></param>
        private delegate void SetCheckBoxCheckedDelegate(CheckBox Ctrl, bool Checked);

        /// <summary>
        /// 获取选择按钮选中状态方法
        /// </summary>
        /// <param name="Ctrl"></param>
        private static bool GetCheckBoxCheckedFunc(CheckBox Ctrl)
        {
            return Ctrl.Checked;
        }

        /// <summary>
        /// 获取选择按钮选中状态
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static bool GetCheckBoxChecked(CheckBox Ctrl)
        {
            return (bool)Ctrl.Invoke(new GetCheckBoxCheckedDelegate(GetCheckBoxCheckedFunc), new object[] { Ctrl });
        }

        /// <summary>
        /// 设置选择按钮选中状态方法
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Checked"></param>
        private static void SetCheckBoxCheckedFunc(CheckBox Ctrl, bool Checked)
        {
            Ctrl.Checked = Checked;
            Ctrl.Refresh();
        }

        /// <summary>
        /// 设置选择按钮选中状态
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Checked"></param>
        public static void SetCheckBoxChecked(CheckBox Ctrl, bool Checked)
        {
            Ctrl.Invoke(new SetCheckBoxCheckedDelegate(SetCheckBoxCheckedFunc), new object[] { Ctrl, Checked });
        }
    }
}
