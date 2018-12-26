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
            //namesBoys.Text = "Paul L., Papa, Martin, Leo, Leon";
            //namesGirls.Text = "Mona, Monica, Erika, Martina, Israelia";
            if(namesGirls.Text == null)
            {
            namesGirls.Placeholder = "Please work";
            }
            if(namesBoys.Text == null)
            {
            namesBoys.Placeholder = "Please work too";

            }
            

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
            boysLength = boysSplit.Length;
            
        }

        private void NamesGirls_Completed(object sender, EventArgs e)
        {
            text2 = ((Editor)sender).Text;            
            girlsSplit = text2.Split(',');            
            girlsLength = girlsSplit.Length;
            
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