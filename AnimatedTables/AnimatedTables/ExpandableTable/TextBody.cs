using System;
using Xamarin.Forms;

namespace AnimatedTables
{
	public class TextBody : StackLayout
	{
		public TextBody (string text)
		{
			this.Orientation = StackOrientation.Horizontal;
			this.Children.Add (new BoxView () { 
					WidthRequest = 1, 
					HorizontalOptions = LayoutOptions.Start,
					Color = Color.Gray,
			});
			this.Children.Add (new StackLayout() {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Padding = 10,
				Children = {
					new Label () { 
						Text = text,
						HorizontalOptions = LayoutOptions.FillAndExpand,
					}
				},
			});
			this.Children.Add (new BoxView () { 
				WidthRequest = 1, 
				HorizontalOptions = LayoutOptions.End,
				Color = Color.Gray,
			});
		}
	}
}

