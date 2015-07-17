using System;
using Xamarin.Forms;

namespace AnimatedTables
{
	public class Footer : StackLayout
	{
		public Footer ()
		{
			this.Padding = 0;
			this.Children.Add(new BoxView() {
				HeightRequest = 1,
				Color = Color.Gray,
				HorizontalOptions = LayoutOptions.FillAndExpand,
			});
		}
	}
}

