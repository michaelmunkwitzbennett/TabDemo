using System;
using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class UpcomingAppointmentsPageCS : ContentPage
	{
		public UpcomingAppointmentsPageCS ()
		{
			
		}

		async void OnBackButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PopAsync ();
		}
	}
}
