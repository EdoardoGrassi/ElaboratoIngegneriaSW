using System;
using Gtk;
using GLib;

namespace IngDelSw
{

public class AuthenticationWindow : Gtk.Window{

		//private Frame mainFrame;
		//private Frame frame2;
		//private Alignment alignThis;

		public AuthenticationWindow() : base (WindowType.Toplevel)
		{ 
			//this.alignThis = new Alignment(0F, 0F, 1F, 1F);
			//this.alignThis.Name = "Allineatore";
			//this.Add (alignThis);
			//this.mainFrame = new Frame ();
			//this.frame2 = new Frame ();
			this.Title = "Titolo di prova";
			Label infoBox1 = new Label();
			Button commit = new Button ("Commit");

			//tweaking components
			this.Resize(500,500);
			infoBox1.Text = "Inserire nome utente e password per ottenere l'accesso.";
			infoBox1.SetAlignment (0.0f, 0.0f);
			commit.Add (infoBox1);

			//Events
			this.DeleteEvent += new DeleteEventHandler (WindowCloser);

			//mainFrame.Add(frame2);
			//frame2.Add(commit);

			//Add components to the window
			this.Add(commit);
			//mainFrame.Add(infoBox1);
			commit.ShowAll();

			//Show / Hide things

			//Show Everything
			//mainFrame.ShowAll();
			//frame2.ShowAll ();
			this.ShowAll();
		}

	public static void WindowCloser(object obj, DeleteEventArgs args)
	{
		SignalArgs sa = (SignalArgs) args;
		Application.Quit();
		sa.RetVal = true;
	}
}
}