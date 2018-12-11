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

            
            //var seperateNames = names.Split(',');
            
		}
    

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wuensche());

        }
    }
}