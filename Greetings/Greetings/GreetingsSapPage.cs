using System;

using Xamarin.Forms;

namespace Greetings
{
	public class GreetingsSapPage : ContentPage
	{
		public GreetingsSapPage()
		{
			FormattedString fs = new FormattedString();
			fs.Spans.Add(new Span() { Text = "I" });
			fs.Spans.Add(new Span() { Text = "Love", FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) });
			fs.Spans.Add(new Span() { Text = "Xamarin" });


			Content = new Label()
			{
				FormattedText = fs,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
				HorizontalTextAlignment = TextAlignment.Center,
				TextColor = Color.FromRgb(255, 0, 0),
				BackgroundColor = Color.Orange,
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				FontAttributes = FontAttributes.Bold | FontAttributes.Italic
			};


			//Device.OnPlatform(iOS: () => { Padding = new Thickness(0, 20, 0, 0);  });

			Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
		}
	}
}

