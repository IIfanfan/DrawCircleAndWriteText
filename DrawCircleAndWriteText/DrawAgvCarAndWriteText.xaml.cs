using System;
using System.Collections.Generic;
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
    /// DrawAgvCarAndWriteText.xaml 的交互逻辑
    /// </summary>
    public partial class DrawAgvCarAndWriteText : UserControl
    {
        public DrawAgvCarAndWriteText()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 设置文本
        /// </summary>
        public string WriteText { get; set; }
        /// <summary>
        /// 设置颜色
        /// </summary>
        public Brush color { get; set; }

        private void Rectangle_Loaded(object sender, RoutedEventArgs e)
        {
            TextName.Text = WriteText;
            TextRectangle.Fill = color;
        }
    }
}
