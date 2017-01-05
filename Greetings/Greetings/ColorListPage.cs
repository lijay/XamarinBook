using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Greetings
{
	public class ColorListPage : ContentPage
	{
		public ColorListPage ()
		{
		    Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5);
		    double size = Device.GetNamedSize(NamedSize.Large, typeof(Label));

			Content = new StackLayout {
				Children = {
					new Label { Text = "Color : Blue", TextColor = Color.Blue}
				}
			};
		}
	}
}
