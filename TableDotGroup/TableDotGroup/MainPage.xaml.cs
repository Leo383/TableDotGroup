using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TableDotGroup
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            logo.Source = ImageSource.FromResource("TableDotGroup.Images.logo.png");

           
        }

        async void Button_Clicked(object sender, EventArgs e)
        {                  
            await Navigation.PushAsync(new Abfrage());
            
        }
    }
}
