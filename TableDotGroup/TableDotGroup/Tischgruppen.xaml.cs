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
	public partial class Tischgruppen : ContentPage
	{
		public Tischgruppen ()
		{
			InitializeComponent ();
            
		}

        private void StepperDreier_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var tischgruppenAnzahl = e;

        }

        private void StepperVierer_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void StepperFuenfer_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Auswertung());

        }
    }
}