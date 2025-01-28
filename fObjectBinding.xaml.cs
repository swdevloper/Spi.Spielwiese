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
using System.Windows.Shapes;

namespace Spi.Spielwiese
{
    /// <summary>
    /// Interaction logic for fObjectBindin.xaml
    /// </summary>
    public partial class fObjectBinding : Window
    {

        private Window _callerWindow;
        private Person _person; 

        public fObjectBinding()
        {
            InitializeComponent();


        }


        public fObjectBinding(Window callerWindow):this()
        {
            _callerWindow = callerWindow;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _callerWindow.Show();
        }



        private void btnLoadObject_Click(object sender, RoutedEventArgs e)
        {
            _person = new Person { Name = "Butterweck", Vorname = "Marcel", Geburtsdatum = DateTime.Today, Email = "marcel.butterweck@butterweck.at" };
            this.DataContext = _person; 

        }
    }
}
