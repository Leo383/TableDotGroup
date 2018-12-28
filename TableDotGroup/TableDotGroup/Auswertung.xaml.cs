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
	public partial class Auswertung : ContentPage
	{
        public double freieSitze;
		public Auswertung (List<string> namesGirls, List<string> namesBoys, double tischgruppenDreier, double tischgruppenVierer, double tischgruppenFuenfer, double tischgruppenSechser)
		{
			InitializeComponent ();
            //print.Text = tischgruppenDreier.ToString() + tischgruppenVierer.ToString() + tischgruppenFuenfer.ToString() + tischgruppenSechser.ToString();
            freieSitze = tischgruppenDreier * 3 + tischgruppenVierer * 4 + tischgruppenFuenfer * 5 + tischgruppenSechser * 6;
            print.Text = freieSitze.ToString();
		}
	}
}