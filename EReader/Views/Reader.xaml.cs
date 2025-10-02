using System.IO;
using System.Windows;

namespace EReader.Views
{
    public partial class Reader : Window
    {
        public Reader()
        {
            InitializeComponent();
        }

        public void LoadPdf(Stream stream, int pageNumber)
        {
            pdfViewer.Load(stream);
            pdfViewer.GotoPage(pageNumber);
            pdfViewer.Visibility = Visibility.Visible;
        }
    }
}
