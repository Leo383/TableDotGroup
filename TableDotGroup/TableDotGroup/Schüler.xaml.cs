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
	public partial class Schüler : ContentPage
	{
		public Schüler ()
		{
			InitializeComponent ();
            

        var alertThat = DisplayAlert("Achtung", "Bitte beachte, dass alle Felder ausgefüllt sind", "Cancel");
        }
        public int boysLength;
        public int girlsLength;
        public string[] boysSplit;
        public string[] girlsSplit;
        char[] charsToTrim = { ' ' };
        


        private void NamesBoys_Completed(object sender, EventArgs e)
        {
            
            var text1 = ((Editor)sender).Text;
            boysSplit = text1.Split(',');
            jungs.Text = text1;
            boysLength = boysSplit.Length;
        }

        private void NamesGirls_Completed(object sender, EventArgs e)
        {
            var text2 = ((Editor)sender).Text;
            girlsSplit = text2.Split(',');
            text2.Trim(charsToTrim);
            maedels.Text = girlsSplit[0] + "\n" + girlsSplit[1];
            girlsLength = girlsSplit.Length;
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            if (namesBoys.Text != null && namesGirls.Text != null)
            {
            await Navigation.PushAsync(new Wuensche(girlsSplit, boysSplit, boysLength, girlsLength ));

            }
            else
            {
                await DisplayAlert("Achtung", "Bitte beachte, dass alle Felder ausgefüllt sind", "Cancel");
            }

        }
    }
}