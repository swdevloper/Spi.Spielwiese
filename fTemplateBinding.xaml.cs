using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for fTemplateBinding.xaml
    /// </summary>
    public partial class fTemplateBinding : Window
    {

        private Window _callerWindow;
        private ObservableCollection<Person> _personList;
        public fTemplateBinding()
        {
            InitializeComponent();
        }


        public fTemplateBinding(Window callerWindow) : this()
        {
            _callerWindow = callerWindow;


            _personList = new ObservableCollection<Person>();
            _personList.Add(new Person { Name = "Butterweck", Vorname = "Marcel", Geburtsdatum = DateTime.Today, Email = "marcel.butterweck@butterweck.at" });
            _personList.Add(new Person { Name = "Butterweck", Vorname = "Andrea", Geburtsdatum = DateTime.Today, Email = "andrea.butterweck@butterweck.at" });
            _personList.Add(new Person { Name = "Butterweck", Vorname = "Luca", Geburtsdatum = DateTime.Today, Email = "luca.butterweck@butterweck.at" });

            
            this.DataContext = _personList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person selectedPerson = this.lstPersons2.SelectedItem as Person;


            MessageBox.Show(string.Format("Hallo {0} {1}!", selectedPerson.Vorname, selectedPerson.Name),"Anzeige",MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}
