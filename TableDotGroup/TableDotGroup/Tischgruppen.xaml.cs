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
        public int girlsLength;
        public int boysLength;
        public double freieSitze;
        public double tischgruppenVierer;
        public double tischgruppenDreier;
        public double tischgruppenFuenfer;
        public double tischgruppenSechser;

        public Tischgruppen ( List<string> _namesGirls, List<string> _namesBoys, int _girlsLength, int _boysLength)
		{
			InitializeComponent ();
            namesBoys = _namesBoys;
            namesGirls = _namesGirls;
            boysLength = _boysLength;
            girlsLength = _girlsLength;


		}
        
        
        

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
            freieSitze = tischgruppenDreier*3 + tischgruppenVierer*4 + tischgruppenFuenfer*5 + tischgruppenSechser*6;
            if(freieSitze == girlsLength + boysLength )
            {
            await Navigation.PushAsync(new Auswertung(namesGirls, namesBoys, tischgruppenDreier, tischgruppenVierer, tischgruppenFuenfer, tischgruppenSechser, freieSitze));
            }
            
            else if (freieSitze <= (girlsLength + boysLength))
            {
                await DisplayAlert("Achtung", "Die Anzahl Tischgruppen ist zu niedrig. Um alle Schüler aufteilen zu können muss die Anzahl der Schüler genau so groß sein wie die Anzahl freier Plätze an den Tischgruppen.", "OK");
                return;
            }

            else
            {
                await DisplayAlert("Achtung", "Die Anzahl Tischgruppen ist zu hoch. Um alle Schüler aufteilen zu können muss die Anzahl der Schüler genau so groß sein wie die Anzahl freier Plätze an den Tischgruppen.", "OK");
                return;
            }
        }

    }
}