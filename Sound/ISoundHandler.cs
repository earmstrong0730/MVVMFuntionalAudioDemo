// --------------------------------------------------------------------------------------------------
//  <copyright file="ISoundHandler.cs" company="Flush Arcade.">
//    Copyright (c) 2014 Flush Arcade. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------

namespace AudioPlayer.Portable.Sound
{
	
	/// Sound handler.
	public interface ISoundHandler
	{
		

		
		/// Gets or sets the is playing.
		bool IsPlaying { get; set; }

		


		
		/// Load this instance.
		void Load();

		
		/// Plays the pause.
		void PlayPause();

		
		/// Stop this instance.
		void Stop();

		
		/// Duration this instance.
		double Duration();

	
		/// Sets the position.
		void SetPosition(double value);

		
		/// Currents the position.
		double CurrentPosition();

		
		/// Forward this instance.
		void Forward();

		
		/// Rewind this instance.
		void Rewind();

	}
}