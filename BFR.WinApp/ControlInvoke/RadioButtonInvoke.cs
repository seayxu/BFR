using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BFR.WinApp.ControlInvoke
{
    /// <summary>
    /// RadioButtonInvoke
    /// </summary>
    public class RadioButtonInvoke
    {
        /// <summary>
        /// 获取单选按钮选中状态委托
        /// </summary>
        /// <param name="Ctrl"></param>
        private delegate bool GetRadioButtonCheckedDelegate(RadioButton Ctrl);
        /// <summary>
        /// 设置单选按钮选中状态委托
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Checked"></param>
        private delegate void SetRadioButtonCheckedDelegate(RadioButton Ctrl, bool Checked);

        /// <summary>
        /// 获取单选按钮选中状态方法
        /// </summary>
        /// <param name="Ctrl"></param>
        private static bool GetRadioButtonCheckedFunc(RadioButton Ctrl)
        {
            return Ctrl.Checked;
        }

        /// <summary>
        /// 获取单选按钮选中状态
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static bool GetRadioButtonChecked(RadioButton Ctrl)
        {
            return (bool)Ctrl.Invoke(new GetRadioButtonCheckedDelegate(GetRadioButtonCheckedFunc), new object[] { Ctrl });
        }

        /// <summary>
        /// 设置单选按钮选中状态方法
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Checked"></param>
        private static void SetRadioButtonCheckedFunc(RadioButton Ctrl, bool Checked)
        {
            Ctrl.Checked = Checked;
            Ctrl.Refresh();
        }

        /// <summary>
        /// 设置单选按钮选中状态
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Checked"></param>
        public static void SetRadioButtonChecked(RadioButton Ctrl, bool Checked)
        {
            Ctrl.Invoke(new SetRadioButtonCheckedDelegate(SetRadioButtonCheckedFunc), new object[] { Ctrl, Checked });
        }
    }
}
