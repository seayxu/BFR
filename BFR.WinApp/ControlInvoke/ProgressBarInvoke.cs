using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BFR.WinApp.ControlInvoke
{
    /// <summary>
    /// ProgressBarInvoke
    /// </summary>
    public class ProgressBarInvoke
    {
        /// <summary>
        /// 获取进度条当前值委托
        /// </summary>
        /// <param name="Ctrl"></param>
        private delegate int GetProgressBarValueDelegate(ProgressBar Ctrl);
        /// <summary>
        /// 设置进度条当前值委托
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        private delegate void SetProgressBarValueDelegate(ProgressBar Ctrl, int Value);

        /// <summary>
        /// 获取进度条最小值委托
        /// </summary>
        /// <param name="Ctrl"></param>
        private delegate int GetProgressBarMinValueDelegate(ProgressBar Ctrl);
        /// <summary>
        /// 设置进度条最小值委托
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        private delegate void SetProgressBarMinValueDelegate(ProgressBar Ctrl, int Value);

        /// <summary>
        /// 获取进度条最大值委托
        /// </summary>
        /// <param name="Ctrl"></param>
        private delegate int GetProgressBarMaxValueDelegate(ProgressBar Ctrl);
        /// <summary>
        /// 设置进度条最大值委托
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        private delegate void SetProgressBarMaxValueDelegate(ProgressBar Ctrl, int Value);

        /// <summary>
        /// 获取进度条当前值方法
        /// </summary>
        /// <param name="Ctrl"></param>
        private static int GetProgressBarValueFunc(ProgressBar Ctrl)
        {
            return Ctrl.Value;
        }

        /// <summary>
        /// 获取进度条当前值
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static int GetProgressBarValue(ProgressBar Ctrl)
        {
            return (int)Ctrl.Invoke(new GetProgressBarValueDelegate(GetProgressBarValueFunc), new object[] { Ctrl });
        }

        /// <summary>
        /// 设置进度条当前值方法
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        private static void SetProgressBarValueFunc(ProgressBar Ctrl, int Value)
        {
            Ctrl.Value = Value;
            Ctrl.Refresh();
        }

        /// <summary>
        /// 设置进度条当前值
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        public static void SetProgressBarValue(ProgressBar Ctrl, int Value)
        {
            Ctrl.Invoke(new SetProgressBarValueDelegate(SetProgressBarValueFunc), new object[] { Ctrl, Value });
        }

        /// <summary>
        /// 获取进度条最小值方法
        /// </summary>
        /// <param name="Ctrl"></param>
        private static int GetProgressBarMinValueFunc(ProgressBar Ctrl)
        {
            return Ctrl.Minimum;
        }

        /// <summary>
        /// 获取进度条最小值
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static int GetProgressBarMinValue(ProgressBar Ctrl)
        {
            return (int)Ctrl.Invoke(new GetProgressBarValueDelegate(GetProgressBarMinValueFunc), new object[] { Ctrl });
        }

        /// <summary>
        /// 设置进度条最小值方法
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        private static void SetProgressBarMinValueFunc(ProgressBar Ctrl, int Value)
        {
            Ctrl.Minimum = Value;
            Ctrl.Refresh();
        }

        /// <summary>
        /// 设置进度条最小值
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        public static void SetProgressBarMinValue(ProgressBar Ctrl, int Value)
        {
            Ctrl.Invoke(new SetProgressBarValueDelegate(SetProgressBarMinValueFunc), new object[] { Ctrl, Value });
        }

        /// <summary>
        /// 获取进度条最大值方法
        /// </summary>
        /// <param name="Ctrl"></param>
        private static int GetProgressBarMaxValueFunc(ProgressBar Ctrl)
        {
            return Ctrl.Maximum;
        }

        /// <summary>
        /// 获取进度条最大值
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <returns></returns>
        public static int GetProgressBarMaxValue(ProgressBar Ctrl)
        {
            return (int)Ctrl.Invoke(new GetProgressBarValueDelegate(GetProgressBarMaxValueFunc), new object[] { Ctrl });
        }

        /// <summary>
        /// 设置进度条最大值方法
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        private static void SetProgressBarMaxValueFunc(ProgressBar Ctrl, int Value)
        {
            Ctrl.Maximum = Value;
            Ctrl.Refresh();
        }

        /// <summary>
        /// 设置进度条最大值
        /// </summary>
        /// <param name="Ctrl"></param>
        /// <param name="Value"></param>
        public static void SetProgressBarMaxValue(ProgressBar Ctrl, int Value)
        {
            Ctrl.Invoke(new SetProgressBarValueDelegate(SetProgressBarMaxValueFunc), new object[] { Ctrl, Value });
        }
    }
}
