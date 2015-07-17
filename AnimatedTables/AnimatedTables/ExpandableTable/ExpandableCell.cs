using System;
using Xamarin.Forms;

namespace AnimatedTables
{
	public class ExpandableCell : StackLayout
	{
		private double bodyHeight = -1;
		private bool expanded = false;
		private Layout body;

		public ExpandableCell (Layout header, Layout body, Layout footer)
		{
			this.Padding = 0;
			this.Spacing = 0;
			this.Children.Add (header);
			this.Children.Add (body);
			this.Children.Add (footer);
			this.body = body;
			this.IsClippedToBounds = true;

			var gestureRecognizer = new TapGestureRecognizer () { };

			gestureRecognizer.Tapped += (sender, e) => {
				double start = expanded ? bodyHeight : 0; // the starting height
				double offset = expanded ? -bodyHeight : bodyHeight; // the change over the animation
				expanded = !expanded;
				this.body.Animate (
					name: "set height",
					animation: new Xamarin.Forms.Animation((val) => {
						this.body.HeightRequest = start + offset*val;
					}),
					length: 250,
					easing: Easing.CubicInOut
				);
			};
			header.GestureRecognizers.Add (gestureRecognizer);
				
		}
		protected override void OnSizeAllocated (double width, double height)
		{
			base.OnSizeAllocated (width, height);
			if (body != null && bodyHeight == -1) { 
				bodyHeight = body.Height;
				Xamarin.Forms.Device.BeginInvokeOnMainThread (() => {
					body.HeightRequest = 0;
				});
			}
		}

	}
}

