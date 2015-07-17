using System;
using Xamarin.Forms;

namespace AnimatedTables
{
	// A header with a Title and Detail
	public class DetailHeader : StackLayout
	{
		public DetailHeader (string title, string detail)
		{
			this.HeightRequest = 70;
			this.Spacing = 0;
			this.Padding = 0;

			var gridView = new Grid () {
				ColumnSpacing = 10,
				Padding = 20,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				ColumnDefinitions = {
					new ColumnDefinition() { Width = new GridLength(60, GridUnitType.Star)},
					new ColumnDefinition() { Width = new GridLength(40, GridUnitType.Star)},
				},
			};
			gridView.Children.Add (new Label () {
				Text = title,
				TextColor = Color.Black,
				FontSize = 24,
				FontAttributes = FontAttributes.Bold,
				LineBreakMode = LineBreakMode.TailTruncation,
				HorizontalOptions = LayoutOptions.StartAndExpand,	
				VerticalOptions = LayoutOptions.CenterAndExpand,
			}, 0, 0);

			gridView.Children.Add (new Label () {
				Text = detail,
				TextColor = Color.Blue,
				FontSize = 20,
				LineBreakMode = LineBreakMode.TailTruncation,
				HorizontalOptions = LayoutOptions.EndAndExpand,	
				VerticalOptions = LayoutOptions.CenterAndExpand,
			}, 1, 0);

			var horizontalStack = new StackLayout () {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Orientation = StackOrientation.Horizontal,
				Children = {
					new BoxView () {
						WidthRequest = 1,
						Color = Color.Gray,
						VerticalOptions = LayoutOptions.FillAndExpand,
						HorizontalOptions = LayoutOptions.Start,
					},
					gridView,
					new BoxView () {
						WidthRequest = 1,
						Color = Color.Gray,
						VerticalOptions = LayoutOptions.FillAndExpand,
						HorizontalOptions = LayoutOptions.End,
					}
				},
			};
			this.Children.Add (
				new BoxView () {
					HorizontalOptions = LayoutOptions.FillAndExpand,
					HeightRequest = 1,
					Color = Color.Gray,
					VerticalOptions = LayoutOptions.Start,
			});
			this.Children.Add (horizontalStack);
		}
				
	}
}

