using System.Windows;
using RP.AGVDispatch.Monitor;

namespace DrawCircleAndWriteText
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DrawAgvCarAndWriteText drawAgvCarAnd = new DrawAgvCarAndWriteText();    //使用其中一个自定义控件
            canvas.Children.Add(drawAgvCarAnd);
        }
    }
}
