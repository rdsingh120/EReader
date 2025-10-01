using EReader.Views;
using System.Windows;

namespace EReader
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            EBookReader eBookReader = new EBookReader();
            eBookReader.ShowDialog();
        }
    }
}