using System;
using Xamarin.Forms;

namespace WorkingWithNavigation
{
	public partial class Page1Xaml : ContentPage
	{
		public Page1Xaml (string date)
		{
			InitializeComponent ();
			datalabel.Text =  date;
		}

		async void OnNextPageButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new Page2Xaml ());
		}
	}
}
