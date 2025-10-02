using EReader.Models;
using System.Windows;

namespace EReader.Views
{
    public partial class EBookReader : Window
    {
        private User currentUser;
        public EBookReader(User user)
        {
            InitializeComponent();
            currentUser = user;
            GreetingTextBlock.Text = "Hello, " + user.UserName;
            BooksList.ItemsSource = currentUser.Books;
        }

    }
}
