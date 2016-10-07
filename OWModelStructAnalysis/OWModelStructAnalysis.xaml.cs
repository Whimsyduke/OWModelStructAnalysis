using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CSharpImageLibrary;

namespace OWModelStructAnalysis
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageEngineImage dds = new ImageEngineImage("C:\\Dates\\Files\\Ha\\Map\\Map\\Maps\\Hollywood\\2AF\\000000001C32.dds");
            Image_Texture.Source = dds.GeneratePreview(0, true);
        }
    }
}
