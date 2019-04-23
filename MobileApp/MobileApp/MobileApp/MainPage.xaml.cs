using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public FormModel Model = new FormModel();

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = Model;
        }
             

        private void PeopleList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("The selected person",peopleList.SelectedItem.ToString(),"Cancel");
        }
    }
}
