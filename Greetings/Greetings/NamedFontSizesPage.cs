using System;
using System.Linq;
using Xamarin.Forms;

namespace Greetings
{
	public class NamedFontSizesPage : ContentPage
	{
		public NamedFontSizesPage()
		{
			FormattedString fs = new FormattedString();

			var enumList = Enum.GetValues(typeof(NamedSize)).Cast<NamedSize>();

			enumList.ToList().ForEach(size => {
				double fontSize = Device.GetNamedSize(size, typeof(Label));

				fs.Spans.Add(new Span() { 
					Text = $"Named Size = {size}, {fontSize}",
					FontSize = fontSize
				});

				if (size != enumList.Last())
				{
					fs.Spans.Add(new Span() { Text = Environment.NewLine + Environment.NewLine });
				}
			});


			Content = new Label() { 
				FormattedText = fs,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center
			};
		}
	}
}

