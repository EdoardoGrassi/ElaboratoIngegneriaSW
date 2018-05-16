using System;
using Gtk;
using GLib;

namespace IngDelSw
{

public class AuthenticationWindow {

		public static void Main2() {
		Application.Init();

		//Create the Window
		Window myWin = new Window("Terapia Intensiva");
		myWin.Resize(500,500);

		//Create a label and put some text in it.
		Label info_box_1 = new Label();
		info_box_1.Text = "Inserire nome utente e password per ottenere l'accesso.";

		myWin.DeleteEvent += new DeleteEventHandler (WindowCloser);

		//Add the label to the form
		myWin.Add(info_box_1);

		//Show Everything
		myWin.ShowAll();

		Application.Run();
	}

	static void WindowCloser(object obj, DeleteEventArgs args)
	{
		SignalArgs sa = (SignalArgs) args;
		Application.Quit();
		sa.RetVal = true;
	}
}

}