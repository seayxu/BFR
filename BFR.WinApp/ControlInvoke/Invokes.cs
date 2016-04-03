using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BFR.WinApp.ControlInvoke
{
    public class Invokes
    {
        #region //Controls

        #region // TextBox
        /// <summary>
        /// 设置文本框文本
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Text"></param>
        public static void SetTextBoxText(TextBox Ctrl, string Text)
        {
            TextBoxInvoke.SetTextBoxText(Ctrl, Text);
        }

        /// <summary>
        /// 获取文本框文本方法
        /// </summary>
        /// <param name="Ctrl"></param>
        public static string GetTextBoxText(TextBox Ctrl)
        {
            return TextBoxInvoke.GetTextBoxText(Ctrl); ;
        }
        #endregion

        #region // Label
        /// <summary>
        /// 设置标签文本
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Text"></param>
        public static void SetLabelText(Label Ctrl, string Text)
        {
            LabelInvoke.SetLabelText(Ctrl, Text);
        }

        /// <summary>
        /// 获取标签文本方法
        /// </summary>
        /// <param name="Ctrl"></param>
        public static string GetLabelText(Label Ctrl)
        {
            return LabelInvoke.GetLabelText(Ctrl); ;
        }
        #endregion 

        #region // RadioButton
        /// <summary>
        /// 获取单选按钮选中状态
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static bool GetRadioButtonChecked(RadioButton Ctrl)
        {
            return RadioButtonInvoke.GetRadioButtonChecked(Ctrl);
        }

        /// <summary>
        /// 设置单选按钮选中状态
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Checked"></param>
        public static void SetRadioButtonChecked(RadioButton Ctrl, bool Checked)
        {
            RadioButtonInvoke.SetRadioButtonChecked(Ctrl, Checked);
        }
        #endregion

        #region // CheckBox
        /// <summary>
        /// 获取选择按钮选中状态
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static bool GetCheckBoxChecked(CheckBox Ctrl)
        {
            return CheckBoxInvoke.GetCheckBoxChecked(Ctrl);
        }

        /// <summary>
        /// 设置选择按钮选中状态
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Checked"></param>
        public static void SetCheckBoxChecked(CheckBox Ctrl, bool Checked)
        {
            CheckBoxInvoke.SetCheckBoxChecked(Ctrl, Checked);
        }
        #endregion

        #region // ProgressBar
        /// <summary>
        /// 获取进度条值
        /// </summary>
        /// <param name="Ctrl"></param>
        public static int GetProgressBarValue(ProgressBar Ctrl)
        {
            return ProgressBarInvoke.GetProgressBarValue(Ctrl);
        }
        /// <summary>
        /// 设置进度条值
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        public static void SetProgressBarValue(ProgressBar Ctrl, int Value)
        {
            ProgressBarInvoke.SetProgressBarValue(Ctrl, Value);
        }

        /// <summary>
        /// 获取进度条最小值
        /// </summary>
        /// <param name="Ctrl"></param>
        public static int GetProgressBarMinValue(ProgressBar Ctrl)
        {
            return ProgressBarInvoke.GetProgressBarMinValue(Ctrl);
        }
        /// <summary>
        /// 设置进度条最小值
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        public static void SetProgressBarMinValue(ProgressBar Ctrl, int Value)
        {
            ProgressBarInvoke.SetProgressBarMinValue(Ctrl, Value);
        }

        /// <summary>
        /// 获取进度条最大值
        /// </summary>
        /// <param name="Ctrl"></param>
        public static int GetProgressBarMaxValue(ProgressBar Ctrl)
        {
            return ProgressBarInvoke.GetProgressBarMaxValue(Ctrl);
        }
        /// <summary>
        /// 设置进度条最大值
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        public static void SetProgressBarMaxValue(ProgressBar Ctrl, int Value)
        {
            ProgressBarInvoke.SetProgressBarMaxValue(Ctrl, Value);
        }
        #endregion

        #endregion

        #region // Common

        #region // Visible
        /// <summary>
        /// 获取控件是否可见委托
        /// </summary>
        /// <param name="Ctrl"></param>
        private delegate bool GetControlVisibleDelegate(Control Ctrl);
        /// <summary>
        /// 设置控件是否可见委托
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Visible"></param>
        private delegate void SetControlVisibleDelegate(Control Ctrl, bool Visible);

        /// <summary>
        /// 获取控件是否可见方法
        /// </summary>
        /// <param name="Ctrl"></param>
        private static bool GetControlVisibleFunc(Control Ctrl)
        {
            return Ctrl.Visible;
        }

        /// <summary>
        /// 获取控件是否可见
        /// </summary>
        /// <param name="flag"></param>
        public static bool GetControlVisible(Control Ctrl)
        {
            return (bool)Ctrl.Invoke(new SetControlVisibleDelegate(SetControlVisibleFunc), new object[] { Ctrl });
        }

        /// <summary>
        /// 设置控件是否可见方法
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Visible"></param>
        private static void SetControlVisibleFunc(Control Ctrl, bool Visible)
        {
            Ctrl.Visible = Visible;
            Ctrl.Refresh();
        }

        /// <summary>
        /// 设置控件是否可见
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Visible"></param>
        public static void SetControlVisible(Control Ctrl, bool Visible)
        {
            Ctrl.Invoke(new SetControlVisibleDelegate(SetControlVisibleFunc), new object[] { Ctrl, Visible });
        } 
        #endregion

        #endregion
    }
}
