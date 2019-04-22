using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp
{
    class PersonModel : ObservableObject
    {
        private string _id,

        public string ID
        {

            get { return _id}
            set
            {
                _id = value;
                NotifyPropertyChanged(nameof(ID));
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                NotifyPropertyChanged(nameof(Age));
            }
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", _id,_name,_age);
        }

    }
}
