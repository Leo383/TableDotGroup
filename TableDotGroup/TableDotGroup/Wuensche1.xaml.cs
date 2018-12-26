using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TableDotGroup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Wuensche1 : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public Wuensche1(string[] girlsSplit, string[] boysSplit, int boysLength, int girlsLength, string text1, string text2)
        {
            InitializeComponent();

            var _girlsSplit = girlsSplit;
            var _boysSplit = boysSplit;

            List<string> names = girlsSplit.ToList() ;
            List<string> namesBoys = boysSplit.ToList();
            names.Sort();
            namesBoys.Sort();
            
            schuelerListe.ItemsSource = names;
            //schuelerListe.ItemsSource.Add(namesBoys);

            
        }


        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
