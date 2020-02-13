// --------------------------------------------------------------------------------------------------
//  <copyright file="ISoundHandler.cs" company="Flush Arcade.">
//    Copyright (c) 2014 Flush Arcade. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------------------------------

namespace AudioPlayer.Portable
{
	using MvvmCross.Platform;

	using AudioPlayer.Portable.ViewModels;


	/// Portable mvx io CR egistrations.
	public static class PortableMvxIoCRegistrations
	{
		
		
		/// Inits the IoC container.
		public static void InitIoC()
		{
			Mvx.IocConstruct<MainPageViewModel>();
			Mvx.IocConstruct<AudioPlayerPageViewModel>();
		}

	}
}