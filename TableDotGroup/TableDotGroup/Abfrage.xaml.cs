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

        private async void Button_Pressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Schüler());
        }
    }
}