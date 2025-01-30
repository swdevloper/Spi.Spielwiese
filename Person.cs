using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spi.Spielwiese
{

    //Model Klasse
    public class Person
    {
        private string _name;
        private string _vorname;
        private DateTime _geburtsdatum;
        private string _email;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Vorname
        {
            get { return _vorname; }
            set { _vorname = value; }
        }
        public DateTime Geburtsdatum
        {
            get { return _geburtsdatum; }
            set { _geburtsdatum = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
