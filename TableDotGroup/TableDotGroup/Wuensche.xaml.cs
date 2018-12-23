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
		public Wuensche (string[] girlsSplit, string[] boysSplit)
		{
			InitializeComponent ();

            string[] _girlsSplit = girlsSplit;
            string[] _boysSplit = boysSplit;

            names.Text = girlsSplit[1];
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tischgruppen());
        }
    }
}