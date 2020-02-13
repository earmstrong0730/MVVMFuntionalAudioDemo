// --------------------------------------------------------------------------------------------------
//  <copyright file="AudioPlayerPage.cs" company="Flush Arcade.">
//    Copyright (c) 2014 Flush Arcade. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------

namespace AudioPlayer.Droid
{
	using Android.App;
	using Android.Graphics;
	using Android.OS;
	using Android.Views;
	using Android.Widget;

	using MvvmCross.Droid.Views;

	using AudioPlayer.Droid.Controls;

	using AudioPlayer.Portable.ViewModels;

	/// Audio player page.
	[Activity(NoHistory = true)]
	public class AudioPlayerPage : MvxActivity
	{
		

		
		/// The playing.
		private bool playing;

		
		/// The play button.
		private ImageButton playButton;

		/// The seek bar.
		private CustomSeekBar _seekBar;

		
		/// The model.
		private AudioPlayerPageViewModel model;




		/// Called when activity is created.
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.AudioPlayerPage);

			_seekBar = FindViewById<CustomSeekBar>(Resource.Id.seekBar);
			_seekBar.ValueChanged += HandleValueChanged;

			playButton = FindViewById<ImageButton>(Resource.Id.PlayButton);
			playButton.SetColorFilter(Color.White);
			playButton.Click += HandlePlayClick;

			var rewindButton = FindViewById<ImageButton>(Resource.Id.RewindButton);
			rewindButton.SetColorFilter(Color.White);
			rewindButton.Click += HandleRewindForwardClick;

			var forwardButton = FindViewById<ImageButton>(Resource.Id.ForwardButton);
			forwardButton.SetColorFilter(Color.White);
			forwardButton.Click += HandleRewindForwardClick;

			model = (AudioPlayerPageViewModel)ViewModel;
		}

	
		/// Called when activity is destroyed.
		protected override void OnDestroy()
		{
			model.Dispose();

			base.OnDestroy();
		}

		



		/// Handles the value changed.
		private void HandleValueChanged(object sender, System.EventArgs e)
		{
			model.UpdateAudioPosition(_seekBar.Progress);
		}


		/// Handles the play click.
		private void HandlePlayClick(object sender, System.EventArgs e)
		{
			playing = !playing;
			playButton.SetImageResource(playing ? Resource.Drawable.pause : Resource.Drawable.play);
		}


		/// Handles the rewind forward click.
		private void HandleRewindForwardClick(object sender, System.EventArgs e)
		{
			playing = false;
			playButton.SetImageResource(Resource.Drawable.play);
		}

		
	}
}