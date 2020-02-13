// --------------------------------------------------------------------------------------------------
//  <copyright file="SplashScreenActivity.cs" company="Flush Arcade.">
//    Copyright (c) 2014 Flush Arcade. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------

namespace AudioPlayer.Droid
{
	using Android.App;
	using Android.OS;

	using MvvmCross.Droid.Views;
	using MvvmCross.Platform;

	using AudioPlayer.Droid.Sound;

	using AudioPlayer.Portable.Sound;
	using AudioPlayer.Portable;


	/// Main page.
	[Activity(Label = "Audio Player")]
	public class MainPage : MvxActivity
	{
	

		
		/// Called when activity is created.
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetupIoC();

			SetContentView(Resource.Layout.MainPage);
		}

		


		/// Setups the io c.
		private void SetupIoC()
		{
			Mvx.RegisterType<ISoundHandler, SoundHandler>();
			PortableMvxIoCRegistrations.InitIoC();
		}

	}
}