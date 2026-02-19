using System.Windows;

namespace Billard_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var db = new Data.Database();
            InitializeComponent();
        }
    }
}