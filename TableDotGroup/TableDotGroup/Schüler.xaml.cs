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
            namesBoys.Text = "Paul, Papa, Martin, Leo, Leon";
            namesGirls.Text = "Mona, Monica, Erika, Martina, Israelia";
            

        var alertThat = DisplayAlert("Achtung", "Bitte beachte, dass alle Felder ausgefüllt sind", "Cancel");
        }
        public int boysLength;
        public int girlsLength;
        public string[] boysSplit;
        public string[] girlsSplit;
        char[] charsToTrim = { ' ' };
        string text1;
        string text2;
        


        private void NamesBoys_Completed(object sender, EventArgs e)
        {
            
            text1 = ((Editor)sender).Text;
            boysSplit = text1.Split(',');
            jungs.Text = text1;
            boysLength = boysSplit.Length;
            for(int i = 0; i < boysLength; i++)
            {
                Console.WriteLine(boysSplit[i] + "\n");
            }
        }

        private void NamesGirls_Completed(object sender, EventArgs e)
        {
            text2 = ((Editor)sender).Text;
            text2.Trim(charsToTrim);
            girlsSplit = text2.Split(',');
            maedels.Text = girlsSplit[0] + "\n" + girlsSplit[1];
            girlsLength = girlsSplit.Length;
            for (int i = 0; i < boysLength; i++)
            {
                Console.WriteLine(girlsSplit[i] + "\n");
            }
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            if (namesBoys.Text != null && namesGirls.Text != null)
            {
            await Navigation.PushAsync(new Wuensche1(girlsSplit, boysSplit, boysLength, girlsLength, text1, text2 ));

            }
            else
            {
                await DisplayAlert("Achtung", "Bitte beachte, dass alle Felder ausgefüllt sind", "Cancel");
            }

        }
    }
}