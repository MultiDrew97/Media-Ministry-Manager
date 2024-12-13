﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using SPPBC.M3Tools.Types.Extensions;

using static M3App.Properties.Resources;

namespace M3App
{
	// The following events are available for MyApplication:
	// Startup: Raised when the application starts, before the startup form is created.
	// Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
	// UnhandledException: Raised if the application encounters an unhandled exception.
	// StartupNextInstance: Raised when launching a single-instance application and the application is already active.
	// NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
	internal partial class M3AppContext : ApplicationContext
	{
		private readonly MediaMinistrySplash splash = new();
		private readonly Timer timer = new() { Interval = (int)TimeSpan.FromSeconds(int.Parse(SPLASH_TIMER)).TotalMilliseconds };

		public M3AppContext()
		{
#if !DEBUG
			splash.Show();
			timer.Tick += StartApp;
			timer.Start();
#else
			StartApp(this, EventArgs.Empty);
#endif
		}

		private async void StartApp(object sender, EventArgs e)
		{
			timer.Stop();
			try
			{
				await LoadApp();

				MainForm = new LoginForm();
				MainForm.Show();
			}
			finally
			{
				splash.Close();
				splash.Dispose();
			}
		}

		protected override void OnMainFormClosed(object sender, EventArgs e)
		{
			// TODO: Figure out how to no longer need this function so that it can be handled more elegantly
			if (Application.OpenForms.Count < 1)
			{
				base.OnMainFormClosed(sender, e);
				return;
			}

			foreach (Form form in Application.OpenForms)
			{
				// Ensures no duplication until I find a better way to handle application exiting
				form.FormClosed -= OnMainFormClosed;
				form.FormClosed += OnMainFormClosed;
			}
		}

		protected override void ExitThreadCore()
		{
			// Perform any application clean up that may be necessary
			base.ExitThreadCore();

			splash.Dispose();
		}

		private async Task LoadApp()
		{
			Debug.WriteLine("Application preamble has begun...");
			splash.UpdateProgress(0);

			// TODO: Perform any startup/loading logic here
#if DEBUG
			Environment.SetEnvironmentVariable(API_BASE_URL, "http://localhost:3000".Encrypt(), Utils.API_VAR_TARGET);
			Environment.SetEnvironmentVariable(API_USERNAME, "username".Encrypt(), Utils.API_VAR_TARGET);
			Environment.SetEnvironmentVariable(API_PASSWORD, "password".Encrypt(), Utils.API_VAR_TARGET);
#else
			Environment.SetEnvironmentVariable(API_BASE_URL, "https://sppbc.herbivore.site".Encrypt(), Utils.API_VAR_TARGET);
			Environment.SetEnvironmentVariable(API_USERNAME, "Preachy2034".Encrypt(), Utils.API_VAR_TARGET);
			Environment.SetEnvironmentVariable(API_PASSWORD, "Wz^8Ne3f3jnkX#456BTd^$#mJqBE!G".Encrypt(), Utils.API_VAR_TARGET);
#endif

			// TODO: Allow this to be done with a service instead
			if (Properties.Settings.Default.UpdateOnStart)
				await SPPBC.M3Tools.Utils.Update(true, false);

			splash.UpdateProgress(50);

			Debug.WriteLine("Application preamble has finished. Starting application...");
			splash.UpdateProgress(100);
		}
	}
}