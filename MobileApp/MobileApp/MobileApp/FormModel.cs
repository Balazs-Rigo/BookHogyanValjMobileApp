using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace MobileApp
{
    class FormModel :ObservableObject
    {
        public FormModel()
        {
            CurrentPerson = new PersonModel();
            People = new ObservableCollection<PersonModel>();
            AddCommand = new Command(ExecuteAddCommand);
        }

        public ICommand AddCommand { get; set; }

        private PersonModel _currentPerson;

        public PersonModel CurrentPerson
        {
            get { return _currentPerson; }
            set
            {
                _currentPerson = value;
                NotifyPropertyChanged(nameof(CurrentPerson));
            }
        }

        public ObservableCollection<PersonModel> People { get; set; }

        private void ExecuteAddCommand(object obj)
        {
            People.Add(CurrentPerson);
            CurrentPerson = new PersonModel();
        }
    }
}
