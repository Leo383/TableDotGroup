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
	public partial class Wuensche : ContentPage
	{
		public Wuensche (string[] girlsSplit, string[] boysSplit, int boysLength, int girlsLength)
		{
			InitializeComponent ();

            string[] _girlsSplit = girlsSplit;
            string[] _boysSplit = boysSplit;



            if (boysLength == 0)
            {
                names.Text = "Default Text";
            }
            else
            {
                names.Text = _girlsSplit[0] + _boysSplit[0];
            }
		}


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tischgruppen());
        }
    }
}