using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Spi.Spielwiese
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSimpleBinding_Click(object sender, RoutedEventArgs e)
        {
            //Beispiel 1 Binding
            fSimpleBinding f = new fSimpleBinding(this);
            f.Show();
            
            this.Hide();

        }

        private void btnObjectBinding_Click(object sender, RoutedEventArgs e)
        {
            fObjectBinding f = new fObjectBinding(this);
            f.Show();

            this.Hide();
        }
    }
}