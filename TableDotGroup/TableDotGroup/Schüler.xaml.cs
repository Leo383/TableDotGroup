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



       

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wuensche());

        }

        private void NamesBoysStrong_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text1 = ((Editor)sender).Text;
            string[] boysStrongSplit = text1.Split(',');
            test.Text = boysStrongSplit[0];
            
            
        }

        private void NamesBoysWeak_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NamesGirlsStrong_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NamesGirlsWeak_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}