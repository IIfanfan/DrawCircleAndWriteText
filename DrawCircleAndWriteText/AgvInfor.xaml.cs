using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RP.AGVDispatch.Monitor
{
    /// <summary>
    /// AgvInfor.xaml 的交互逻辑
    /// </summary>
    public partial class AgvInfor : UserControl
    {
        public AgvInfor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Agv小车名字
        /// </summary>
        public string AgvName { get; set; }

        /// <summary>
        /// Agv小车状态
        /// </summary>
        public byte AgvSate { get; set; }

        /// <summary>
        /// 呼叫执行任务
        /// </summary>
        public int TriggerId { get; set; }

        /// <summary>
        /// 坐标X
        /// </summary>
        public double PositionX { get; set; }

        /// <summary>
        /// 坐标Y
        /// </summary>
        public double PositionY { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public double Weight { get; set; }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            txtAgvCarName.Text = AgvName;
            if (AgvSate == (byte)AgvStateInfor.Charge)
            {
                stateAgvStatus.Fill = Brushes.Green;
            }
            else if (AgvSate == (byte)AgvStateInfor.Abnormal)
            { 
                stateAgvStatus.Fill = Brushes.Red;
            }
            txtAgvStatus.Text = "2";
            txtAgvTask.Text = TriggerId.ToString() + "站台";
            txtPositionX.Text = PositionX.ToString("f3");
            txtPositionY.Text = PositionY.ToString("f3");
            txtWeight.Text = Weight.ToString("f1") + "Kg";
        }
        private enum AgvStateInfor
        {
            [Description("正常")]
            Normal = 0,
            [Description("异常")]
            Abnormal = 1,
            [Description("充电")]
            Charge = 2

        }
    }
}
