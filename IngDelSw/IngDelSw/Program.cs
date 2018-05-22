using System;
using Gtk;


namespace ProgettoIngegneriaSW
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			Authentication loginScreen = new Authentication ();
			loginScreen.Show ();

			Application.Run ();
		}
	}
}
