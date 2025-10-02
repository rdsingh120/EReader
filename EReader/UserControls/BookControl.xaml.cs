using EReader.Models;
using EReader.Services;
using EReader.Views;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace EReader.UserControls
{
    public partial class BookControl : UserControl
    {
        public BookControl()
        {
            InitializeComponent();
        }
        private async void BookCard_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (this.DataContext is Book book)
            {
                try
                {
                    Reader reader = new Reader();
                    S3Operations s3Operations = new S3Operations();
                    Stream bookStream = await s3Operations.GetBook(book.Name);

                    reader.LoadPdf(bookStream, book.LastReadPageNumber);
                    reader.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("DataContext is: " + (this.DataContext?.GetType().FullName ?? "null"));
            }
        }

    }
}
