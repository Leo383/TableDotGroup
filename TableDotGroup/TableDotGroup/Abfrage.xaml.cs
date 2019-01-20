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
            await DisplayAlert("Information", "Gespeicherte Schülerlisten folgen im nächsten Update", "OK");

        }

        private async void Dice_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Information", "Einen Schüler zufällig ziehen folgt im nächsten Update", "OK");
            //await Navigation.PushAsync(new DrawAbfrage());

        }
    }   
}