using System;
using Gtk;


namespace IngDelSw
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			AuthenticationWindow.Main2();
			win.Show ();
			Application.Run ();
		}
	}
}
