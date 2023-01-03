using System;
using System.Net.Cache;
using Xamarin.Forms;

namespace WorkingWithNavigation
{
	public partial class Page2aXaml : ContentPage
	{
		public Page2aXaml ()
		{
			InitializeComponent ();
		}

		async void OnNextPageButtonClicked (object sender, EventArgs e)
		{
			var contact = new Contact
			{
				Name = "Arman",
				Age = "Secret",
				Occupation = "Developer",
				Country = "Philippines"

			};

			var thirdPage = new Page3Xaml();
				thirdPage.BindingContext= contact;
			await Navigation.PushAsync (thirdPage);
		}

		async void OnPreviousPageButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PopAsync ();
		}
	}
}
