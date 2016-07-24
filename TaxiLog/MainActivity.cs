using System;
using System.Runtime.InteropServices;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TaxiLog
{
	[Activity(Label = "TaxiLog", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.MyButton);

			button.Click += delegate
			{
				var geoUri = Android.Net.Uri.Parse("google.navigation:q=Swiss+Hotel, +Sonoma+California");
				var mapIntent = new Intent(Intent.ActionView, geoUri);
				StartActivity(mapIntent);
			};

			Button button2 = FindViewById<Button>(Resource.Id.LodgeInn);

			button2.Click += delegate
			{
				var geoUri = Android.Net.Uri.Parse("google.navigation:q=Lodge+Inn, +Sonoma+California");
				var mapIntent = new Intent(Intent.ActionView, geoUri);
				StartActivity(mapIntent);
			};

			Button button3 = FindViewById<Button>(Resource.Id.GirlAndFig);

			button3.Click += delegate
			{
				var geoUri = Android.Net.Uri.Parse("google.navigation:q=Girl+And+The+Fig, +Sonoma+California");
				var mapIntent = new Intent(Intent.ActionView, geoUri);
				StartActivity(mapIntent);
			};

			Button button4 = FindViewById<Button>(Resource.Id.EasyStop);

			button4.Click += delegate
			{
				NavToMap("google.navigation:q=Easy+Stop, +Sonoma+California");
			};

			Button button5 = FindViewById<Button>(Resource.Id.lbl1);

			button5.Click += delegate
			{
				NavToMap("google.navigation:q=Marys+Pizza+on+12, +Sonoma+California");
			};

			Button button6 = FindViewById<Button>(Resource.Id.lbl2);

			button6.Click += delegate
			{
				NavToMap("google.navigation:q=Marys+Pizza+on+spain, +Sonoma+California");
			};

			Button button7 = FindViewById<Button>(Resource.Id.lbl3);

			button7.Click += delegate
			{
				NavToMap("google.navigation:q=Sonoma+Valley+Hospital, +Sonoma+California");
			};

			Button button8 = FindViewById<Button>(Resource.Id.lbl4);

			button8.Click += delegate
			{
				NavToMap("google.navigation:q=Brookdale+Sonoma, +Sonoma+California");
			};

			Button button9 = FindViewById<Button>(Resource.Id.lbl5);

			button9.Click += delegate
			{
				NavToMap("google.navigation:q=Sonoma+Hills+Retirement, +Sonoma+California");
			};

			Button button10 = FindViewById<Button>(Resource.Id.lbl6);

			button10.Click += delegate
			{
				NavToMap("google.navigation:q=Sonoma+Point+Apartments, +Sonoma+California");
			};

		}

		private void NavToMap(string loc)
		{
			var geoUri = Android.Net.Uri.Parse(loc);
			var mapIntent = new Intent(Intent.ActionView, geoUri);
			StartActivity(mapIntent);
		}
	}
}

