using System;

using Xamarin.Forms;

namespace AccordionEx
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new HomePage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

	}

	public class ListDataViewCell : ViewCell
	{
		public ListDataViewCell()
		{
			var label = new Label()
			{
				Font = Font.SystemFontOfSize(NamedSize.Default),
				TextColor = Color.Blue
			};
			label.SetBinding(Label.TextProperty, new Binding("TextValue"));
			label.SetBinding(Label.ClassIdProperty, new Binding("DataValue"));
			View = new StackLayout()
			{
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.StartAndExpand,
				Padding = new Thickness(12, 8),
				Children = { label }
			}; }
	}

	public class SimpleObject {
		public string TextValue 
		{ get; set; }
		public string DataValue 
		{ get; set; }
	}
}

