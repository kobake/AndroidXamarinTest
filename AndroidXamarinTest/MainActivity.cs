using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidXamarinTest
{
	[Activity(Label = "AndroidXamarinTest", MainLauncher = true, Icon = "@drawable/icon")]
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

			button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
		}

		[Java.Interop.Export("OnClickButton1")]
		public void OnClickButton1(View v)
		{
			Toast.MakeText(this, "1 desu", ToastLength.Short).Show();
		}
	}
}

