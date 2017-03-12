using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungPersonen
{
    class Student : Person
    {
        private string _fieldOfStudy;
        public string fieldOfStudy
        {
            get { return _fieldOfStudy; }
            set { _fieldOfStudy = value; }
        }

        private int _module;
        public int module
        {
            get { return _module; }
            set { _module = value; }
        }

        private DateTime _studyBegin;
        public DateTime studyBegin
        {
            get { return _studyBegin; }
            set { _studyBegin = value; }
        }

        private int _studyNumber;
        public int studyNumber
        {
            get { return _studyNumber; }
            set { _studyNumber = value; }
        }

        private string _institute;
        public string institute
        {
            get { return _institute; }
            set { _institute = value; }
        }

        public Student()
        {

        }

        //public Student(string prename, string surname, DateTime birthday, string city, string street, int streetNumber, int zip, string nationality, string fieldOfStudy, int module, DateTime studyBegin, int studyNumber, string institute)
        //{
        //    base.prename = prename;
        //    base.surname = surname;
        //    base.birthday = birthday;
        //    base.city = city;
        //    base.street = street;
        //    base.streetNumber = streetNumber;
        //    base.zip = zip;
        //    base.nationality = nationality;
        //    _fieldOfStudy = fieldOfStudy;
        //    _module = module;
        //    _studyBegin = studyBegin;
        //    _studyNumber = studyNumber;
        //    _institute = institute;
        //}

        public Student(string prename, string surname, DateTime birthday, string city, string street, int streetNumber, int zip, string nationality, string fieldOfStudy, int module, DateTime studyBegin, int studyNumber, string institute) 
            : base(prename, surname, birthday, city, street, streetNumber, zip, nationality)
        {
            _fieldOfStudy = fieldOfStudy;
            _module = module;
            _studyBegin = studyBegin;
            _studyNumber = studyNumber;
            _institute = institute;
        }


        public override string ToString()
        {
            return base.ToString() + " Studiennummer: " + _studyNumber;
        }

    }

}
