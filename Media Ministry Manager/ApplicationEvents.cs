﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using NPOI.SS.Formula.Functions;

namespace M3App
{

    // The following events are available for MyApplication:
    // Startup: Raised when the application starts, before the startup form is created.
    // Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    // UnhandledException: Raised if the application encounters an unhandled exception.
    // StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    // NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    internal partial class M3ApplicationContext : ApplicationContext
	{
		private MediaMinistrySplash splash = new();

		// TODO: Create a timer to show the splash screen for 5 seconds then close and open the application. Opening the application in the background and opening after the thred is over
		// MAYBE: Background worker? Timer?
		public M3ApplicationContext(string[] args)
		{
			//splash.Show();
			//Utils.Wait(5);
			LoadApp();
			MainForm = new LoginForm();
		}

		protected override void OnMainFormClosed(object sender, EventArgs e)
		{
			if (Application.OpenForms.Count > 0) return;

			base.OnMainFormClosed(sender, e);
		}

		protected override void ExitThreadCore()
		{
			// Perform any application clean up that may be necessary
			base.ExitThreadCore();
		}

		private void LoadApp()
		{
			Console.WriteLine("Checking for previous settings...");
			if (Properties.Settings.Default.UpgradeRequired)
			{
				try
				{
					// Bring in the settings from previous version
					Console.WriteLine("Previous settings found. Importing previous settings...");
					Properties.Settings.Default.KeepLoggedIn = false;
					Properties.Settings.Default.Upgrade();
					Properties.Settings.Default.UpgradeRequired = false;
					Properties.Settings.Default.Save();
				}
				catch
				{
					Console.WriteLine("Unable to import previous settings. Using defaults");
				}
			}

			splash.UpdateProgress(50);
			//Utils.Wait(2);

			// FIXME: Use this until I find a better way to do this. Once figured out, revert settings to Application instead of User settings
#if DEBUG
			Console.WriteLine("DEBUG: Changing API settings for debug settings");
			Properties.Settings.Default.BaseUrl = "http://localhost:3000/api";
			Properties.Settings.Default.ApiPassword = "password";
			Properties.Settings.Default.ApiUsername = "username";
			Properties.Settings.Default.Save();
#endif

			Console.WriteLine("Application preamble has finished. Starting application...");
			splash.UpdateProgress(100);
			// Utils.Wait(2);
			splash.Close();
			splash.Dispose();
			splash = null;
			// new LoginForm().Show();
			// Context.Post(_ => new LoginForm().Show(), null);
		}

		//private static void StartApplication(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		//{
		//	if (e.Error != null)
		//	{
		//		MessageBox.Show($"Unable to start application. Please reach out to your administrator.\n\nError:\n\t{e.Error.Message}");
		//		return;
		//	}

		//	if (e.Cancelled)
		//	{
		//		Console.WriteLine("Application preamble was canceled from finishing");
		//		return;
		//	}

		//	// Close the splash screen and show the application
		//	Console.WriteLine("Closing splash screen...");
		//	splash.Close();
		//	splash.Dispose();
		//	splash = null;

		//	while (true)
		//	{
		//		Console.WriteLine("Checking if forms are closed...");
		//		if (Application.OpenForms.Count > 0)
		//		{
		//			Utils.Wait(5);
		//			continue;
		//		}

		//		Console.WriteLine("Application is being exited");

		//		// TODO: Figure out how the wording of this documentation can be used for better error handling and such
		//		//
		//		//		Returns whether any Form within the application cancelled the exit.
		//		Application.Exit(new(true));
		//		break;
		//	}
		//}
	}
}
