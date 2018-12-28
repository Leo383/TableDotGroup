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


            //namesBoys.Placeholder = "Paul, Martin, ...";
            //namesBoys.AutoSize = EditorAutoSizeOption.TextChanges;
            //namesBoys.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);

            //namesGirls.Placeholder = "Erika, Martina, ...";
            //namesGirls.AutoSize = EditorAutoSizeOption.TextChanges;
            //namesGirls.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeWord);
            
        }

        public int boysLength;
        public int girlsLength;
        public string[] boysSplit;
        public string[] girlsSplit;        
        string text1;
        string text2;
        


        private void NamesBoys_Completed(object sender, EventArgs e)
        {
            if (namesBoys.Text != null)
            {

                text1 = ((Editor)sender).Text;
                boysSplit = text1.Split(',');
                boysLength = boysSplit.Length;
            }
            else { return; };
            
        }

        private void NamesGirls_Completed(object sender, EventArgs e)
        {
            if (namesGirls.Text != null)
            {

                text2 = ((Editor)sender).Text;
                girlsSplit = text2.Split(',');
                girlsLength = girlsSplit.Length;

            }
            else { return; };
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