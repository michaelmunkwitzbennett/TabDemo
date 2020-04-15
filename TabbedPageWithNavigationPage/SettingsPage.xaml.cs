using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}

		void calculate_clicked(Object sender, EventArgs args)
		{
			int age = Int32.Parse(yourAge.Text);
			if (age < 16)
			{
				result.Text = "You are too young to drive";
			} else if (age == 16)
			{
				result.Text = "You just learned how to drive this year!";
			} else if (age == 17)
			{
				result.Text = "You have been driving for 1 year";
			} 
			else
			{
				int yearsDriveable = age - 16;
				result.Text = "You have been driving for " + yearsDriveable + " years";
			}
		}
	}
}

