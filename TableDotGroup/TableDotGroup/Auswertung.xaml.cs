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
        static Random random = new Random();
        public double freieSitze;
        public int m;
        public int f;
		public Auswertung (List<string> namesGirls, List<string> namesBoys, double tischgruppenDreier, double tischgruppenVierer, double tischgruppenFuenfer, double tischgruppenSechser, double freieSitze)
		{
			InitializeComponent ();

            print.Text = freieSitze.ToString();
            namesBoys[1].ToString();


            
            m = random.Next(0, namesBoys.Count());
            f = random.Next(0, namesGirls.Count());
            
            
            while(namesBoys.Count() > 0)
            {
                var picked = namesBoys[m];
                namesBoys.Remove(picked);
            }
            
		}
	}
}