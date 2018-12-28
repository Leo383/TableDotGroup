using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

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
            
            for (int i = 0; i < _boysSplit.Length; i++)
            {
                _boysSplit[i] = _boysSplit[i].TrimStart();
            };

            for (int i = 0; i < _girlsSplit.Length; i++)
            {
                _girlsSplit[i] = _girlsSplit[i].TrimStart();               
            };


            List<string> namesGirls = _girlsSplit.ToList() ;
            List<string> namesBoys = _boysSplit.ToList();

            namesGirls.Sort();
            namesBoys.Sort();
            
            
            schuelerListe.ItemsSource = namesGirls.Concat(namesBoys);
            
            
        }
            


        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //var savedList = JsonConvert.SerializeObject(schuelerListe); Converts List into TextFile
            await Navigation.PushAsync(new Tischgruppen());
        }
    }
}
