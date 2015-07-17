using System;
using Xamarin.Forms;

namespace AnimatedTables
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new ScrollView () {
					Content = new StackLayout {
						Padding = 20,
						Spacing = 20,
						Children = {
							new ExpandableCell (
								new DetailHeader ("Antimony", "♁"),
								new TextBody (
									@"Antimony is a chemical element with symbol Sb (from Latin: stibium) " +
									"and atomic number 51. A lustrous gray metalloid, it is found in " +
									"nature mainly as the sulfide mineral stibnite (Sb2S3). \n\nAntimony " +
									"compounds have been known since ancient times and were used for cosmetics; " + 
									"metallic antimony was also known, but it was erroneously identified as " +
									"lead upon its discovery."
								),
								new Footer ()
							),
							new ExpandableCell (
								new DetailHeader ("Iron", "♂"),
								new TextBody (
									@"Iron is a chemical element with symbol Fe (from Latin: ferrum) and" +
									" atomic number 26. It is a metal in the first transition series. " +
									"\n\nIt is by mass the most common element on Earth, forming much of " +
									"Earth's outer and inner core. It is the fourth most common element " +
									"in the Earth's crust."
								),
								new Footer ()
							),
							new ExpandableCell (
								new DetailHeader ("Mercury", "☿"),
								new TextBody (
									@"Mercury is a chemical element with symbol Hg and atomic number 80." +
									" It is commonly known as quicksilver and was formerly named " +
									"hydrargyrum (/haɪˈdrɑrdʒərəm/).\n\nA heavy, silvery d-block element," +
									"mercury is the only metallic element that is liquid at standard " +
									"conditions for temperature and pressure." 
								),
								new Footer ()
							),
						},
					},
				},
			};
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
}

