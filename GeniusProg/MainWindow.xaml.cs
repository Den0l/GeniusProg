using System.Text;
using System.Windows;
using FileSerilizLibrary;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace GeniusProg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists( Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Tests.json")) { 
                App.Theme = FileSeriliz.Deserilaz<string>();
            }
        }

        private void FunBut_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = "PinkGrey";
            FileSeriliz.Serilaz("PinkGrey");
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = "BlackWhite";
            FileSeriliz.Serilaz("BlackWhite");
        }
    }
}