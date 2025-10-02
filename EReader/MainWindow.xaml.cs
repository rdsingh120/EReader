using EReader.Models;
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

            User? user = await LoginOperation.CheckCredentails(userName, password);



            if (user != null)
            {
                EBookReader eBookReader = new EBookReader(user);
                this.Hide();
                eBookReader.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            
        }
    }
}