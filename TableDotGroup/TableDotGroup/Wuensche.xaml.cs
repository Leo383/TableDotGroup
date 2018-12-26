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
		public Wuensche () //string[] girlsSplit, string[] boysSplit, int boysLength, int girlsLength
        {
			InitializeComponent ();
            //string[] _girlsSplit = girlsSplit;
            //string[] _boysSplit = boysSplit;


            //schuelerListe.ItemsSource = _girlsSplit;
            //for (int i = 0; i < girlsLength; i++)
            //{
            //    schuelerListe.ItemsSource.Add(_girlsSplit[i]);

            //};


        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tischgruppen());
        }
    }
}