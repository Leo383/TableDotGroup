using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TableDotGroup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abfrage : ContentPage
    {
        public Abfrage()
        {
            InitializeComponent();
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Schüler());
        }

        private async void Clock_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Info", "In Zukunft", "OK");

        }

        private async void Dice_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Draw());

        }
    }   
}