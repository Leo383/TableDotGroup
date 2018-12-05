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
		public Tischgruppen ()
		{
			InitializeComponent ();
            
		}

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var tischgruppenAnzahl = e;

        }
    }
}