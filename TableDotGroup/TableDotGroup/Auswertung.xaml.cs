using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;

namespace TableDotGroup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Auswertung : ContentPage
    {
        static Random random = new Random();
        public string groupsOfThree;
        public string groupsOfFour;
        public string groupsOfFive;
        public string groupsOfSix;       
        public IEnumerable<string> schuelerListe;



        public Auswertung (List<string> namesGirls, List<string> namesBoys, double tischgruppenDreier, double tischgruppenVierer, double tischgruppenFuenfer, double tischgruppenSechser, double freieSitze)
		{
			InitializeComponent ();
            var list = new PersonList();


            schuelerListe = namesGirls.Concat(namesBoys);



            #region Get the groups
            for (int i = 0; i < namesBoys.Count(); i++)
            {
                list.AddBoy(namesBoys[i]);
            }

            for (int i = 0; i < namesGirls.Count(); i++)
            {
                list.AddGirl(namesGirls[i]);
            }



            for (int i = 0; i < tischgruppenVierer; i++)
            {

                groupsOfFour = "4: " + String.Join(", ", list.GetGroup(4)) + "\n";
                TablesFour.Text += groupsOfFour;
            }

            for (int i = 0; i < tischgruppenSechser; i++)
            {

                groupsOfSix = "6: " + String.Join(", ", list.GetGroup(6)) + "\n";
                TablesSix.Text += groupsOfSix;
            }

            for(int i = 0; i < tischgruppenDreier; i++)
            {

                groupsOfThree = "3: " + String.Join(", ", list.GetGroup(3)) + "\n";
                TablesThree.Text += groupsOfThree;
            }


            for (int i = 0; i < tischgruppenFuenfer; i++)
            {

                groupsOfFive = "5: " + String.Join(", ", list.GetGroup(5)) + "\n";
                TablesFive.Text += groupsOfFive;
                
            }
            
            var getgroups = list.GetGroup(4);
            var groupOf5 = list.GetGroup(5);

            if(TablesThree.Text == null)
            {
                title3.IsVisible = false;
            }

            if (TablesFour.Text == null)
            {
                title4.IsVisible = false;
            }

            if (TablesFive.Text == null)
            {
                title5.IsVisible = false;
            }

            if (TablesSix.Text == null)
            {
                title6.IsVisible = false;
            }

        }
        #endregion
        #region Executed Code to ranodmize
        public class PersonList
        {


            private List<string> boys = new List<string>();
            private List<string> girls = new List<string>();

            public void AddBoy(string name)
            {
                boys.Add(name);
            }
            public void AddGirl(string name)
            {
                girls.Add(name);
            }

            

            public IEnumerable<string> GetGroup(int size)
            {
                Shuffle(boys);
                Shuffle(girls);
                if ((boys.Count + girls.Count) < size)
                {
                    throw new ArgumentException("Not enough people to satisfy group");
                }
                bool isBoy = rng.NextDouble() > 0.5;
                for (var i = 0; i < size; i++)
                {
                    string next = "";
                    if (isBoy)
                    {
                        yield return PopBoy();
                    }
                    else
                    {
                        yield return PopGirl();
                    }
                    isBoy = !isBoy;
                }
            }

            private string PopBoy()
            {
                if (boys.Count > 0)
                {
                    var name = boys[0];
                    boys.RemoveAt(0);
                    return name;
                }
                else
                {
                    return PopGirl();
                }
            }
            private string PopGirl()
            {
                if (girls.Count > 0)
                {
                    var name = girls[0];
                    girls.RemoveAt(0);
                    return name;
                }
                else
                {
                    return PopBoy();
                }
            }

            private static Random rng = new Random();

            private static void Shuffle<T>(IList<T> list)
            {
                int n = list.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    T value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
            }
        }
        #endregion

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Information", "Das Abspeichern von Schülerlisten folgt im nächsten Update", "OK");
            //System.IO.File.WriteAllLines(nameKlasse.Text, schuelerListe);
        }
    }
}