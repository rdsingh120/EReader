using EReader.Services;
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

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = UsernameTextBox.Text;
            string password = LoginPasswordBox.Password;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter the username");
                return;
            }

            bool isValid = await LoginOperation.CheckCredentails(userName, password);



            if (isValid)
            {
                EBookReader eBookReader = new EBookReader();
                this.Hide();
                eBookReader.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            
        }
    }
}