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
    /// Interaction logic for fBspMVVM.xaml
    /// </summary>
    public partial class fBspMVVM : Window
    {
        private Window _callerWindow;

        public fBspMVVM()
        {
            InitializeComponent();
        }


        public fBspMVVM(Window callerWindow) : this()
        {
            _callerWindow = callerWindow;

            this.DataContext = new fBspMVVVMViewModel();

        }

    }
}
