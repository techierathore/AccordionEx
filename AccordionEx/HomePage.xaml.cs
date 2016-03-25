using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AccordionEx
{
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

		public void OnXamlClicked (object sender, EventArgs args){

			Navigation.PushAsync(new XamlExample());

		}
		public void OnCodeClicked (object sender, EventArgs args){

			Navigation.PushAsync(new CodeEaxmple());

		}
	}
}

