using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spi.Spielwiese
{
    public class fBspMVVVMViewModel
    {

        private ObservableCollection<Person> _personList;
        private Person _selectedPerson;



        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value; }
        }

        public ObservableCollection<Person> PersonList
        {
            get { return _personList; }
            set { _personList = value; }
        }

        public fBspMVVVMViewModel()
        {

            _personList = new ObservableCollection<Person>();
            _personList.Add(new Person { Name = "Butterweck", Vorname = "Marcel", Geburtsdatum = DateTime.Today, Email = "marcel.butterweck@butterweck.at" });
            _personList.Add(new Person { Name = "Butterweck", Vorname = "Andrea", Geburtsdatum = DateTime.Today, Email = "andrea.butterweck@butterweck.at" });
            _personList.Add(new Person { Name = "Butterweck", Vorname = "Luca", Geburtsdatum = DateTime.Today, Email = "luca.butterweck@butterweck.at" });


        }




    }
}
