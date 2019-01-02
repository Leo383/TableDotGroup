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
        public double dreierTischFrei;


        public class TischDrei
        {
            public string student;
        }

        public class TischVier
        {
            public string student;
        }

        public class TischFuenf
        {
            public string student;
        }

        public class TischSechs
        {
            public string student;
        }

        
		public Auswertung (List<string> namesGirls, List<string> namesBoys, double tischgruppenDreier, double tischgruppenVierer, double tischgruppenFuenfer, double tischgruppenSechser, double freieSitze)
		{
			InitializeComponent ();



            for (int i = 0; i < tischgruppenDreier; i++)    //Group of 3
            {

                for (int j = 0; j < 4; j++)
                {
                    var picked = namesBoys[random.Next(0, namesBoys.Count())];
                    namesBoys.Remove(picked);
                    picked = new TischDrei().student;

                }
            }

            for (int i = 0; i < tischgruppenVierer; i++) //for each group of 4
            {

                for (int j = 0; j < 4/2; j++) //only do this two times because 50% boys
                {
                    var picked = namesBoys[random.Next(0, namesBoys.Count())]; 
                    namesBoys.Remove(picked);
                    List<string> alleTische = new List<TischVier>();
                    TischVier t = new TischVier();
                    t.student = picked;
                    alleTische.Add(t.student);

                }
            }

            for (int i = 0; i < tischgruppenFuenfer; i++) //Fuenfer Tisch
            {

                for (int j = 0; j < 4; j++)
                {
                    var picked = namesBoys[random.Next(0, namesBoys.Count())];
                    namesBoys.Remove(picked); 
                    picked = new TischFuenf().student;

                }
            }

            for (int i = 0; i < tischgruppenSechser; i++) // Sechser TIsch
            {

                for (int j = 0; j < 4; j++)
                {
                    var picked = namesBoys[random.Next(0, namesBoys.Count())];
                    namesBoys.Remove(picked);
                    picked = new TischSechs().student;

                }
            }


        }
	}
}