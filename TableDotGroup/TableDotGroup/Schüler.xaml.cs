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
            

        }
        public string[] boysSplit;
        public string[] girlsSplit;


        private void NamesBoys_Completed(object sender, EventArgs e)
        {
            var text1 = ((Editor)sender).Text;
            boysSplit = text1.Split(',');
            jungs.Text = text1;
        }

        private void NamesGirls_Completed(object sender, EventArgs e)
        {
            var text2 = ((Editor)sender).Text;
            girlsSplit = text2.Split(',');
            text2.Trim(' ');
            maedels.Text = girlsSplit[0] + "\n" + girlsSplit[2]; 
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wuensche(girlsSplit, boysSplit ));

        }
    }
}