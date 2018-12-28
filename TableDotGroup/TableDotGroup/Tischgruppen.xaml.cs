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
	public partial class Tischgruppen : ContentPage
	{
        public List<string> namesBoys;
        public List<string> namesGirls;

		public Tischgruppen ( List<string> _namesGirls, List<string> _namesBoys)
		{
			InitializeComponent ();
            namesBoys = _namesBoys;
            namesGirls = _namesGirls;

		}
        public double tischgruppenVierer;
        public double tischgruppenDreier;
        public double tischgruppenFuenfer;
        public double tischgruppenSechser;
        
        

        private void StepperDreier_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tischgruppenDreier = e.NewValue;

        }

        private void StepperVierer_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tischgruppenVierer = e.NewValue;
        }

        private void StepperFuenfer_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tischgruppenFuenfer = e.NewValue;
        }

        private void StepperSechser_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tischgruppenSechser = e.NewValue;
        }


        private async void Button_Pressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Auswertung(namesGirls, namesBoys, tischgruppenDreier, tischgruppenVierer, tischgruppenFuenfer, tischgruppenSechser));
            
        }

    }
}