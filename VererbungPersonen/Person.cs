using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungPersonen
{
    class Person
    {
        private string _prename;
        public string prename
        {
            get { return _prename; }
            set { _prename = value; }
        }

        private string _surname;
        public string surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        private DateTime _birthday;
        public DateTime birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        private string _city;
        public string city
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _street;
        public string street
        {
            get { return _street; }
            set { _street = value; }
        }

        private int _streetNumber;
        public int streetNumber
        {
            get { return _streetNumber; }
            set { _streetNumber = value; }
        }

        private int _zip;
        public int zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        private string _nationality;
        public string nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }

        public Person() 
        {
        }
        public Person(string prename, string surname, DateTime birthday, string city, string street, int streetNumber, int zip, string nationality)
        {
            _prename = prename;
            _surname = surname;
            _birthday = birthday;
            _city = city;
            _street = street;
            _streetNumber = streetNumber;
            _zip = zip;
            _nationality = nationality;
        }

        public override string ToString()
        {
            return String.Format("Vorname: {0}, Name: {1}", _prename, _surname);
        }

    }
}
