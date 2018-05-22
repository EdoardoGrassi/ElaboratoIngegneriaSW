using System;
using Gtk;
using GLib;

namespace ProgettoIngegneriaSW
{
	public partial class Authentication : Gtk.Window
	{ 
		public Authentication () :
		base (Gtk.WindowType.Toplevel)
		{
			this.Title = "Login";
			this.BorderWidth = 10;
			//this.SetDefaultSize (200, 200);
			this.Resizable = false;

			VBox mainBox = new VBox ();
			Frame formFrame = new Frame (); //only container in this window to have a frame -> aesthetic purpose
			//Start with labels
			Label userInfo = new Label ("Welcome! Authenticate to access data: ");
			//labelFrame.Add (userInfo);
			mainBox.Add(userInfo);

			//entries
			Entry username = new Entry ();
			Entry password = new Entry ();

			password.Visibility = false;

			Label usernameLabel = new Label ("Username");
			Label passwordLabel = new Label ("Password");

			VBox entryBox = new VBox (); 
			VBox labelEntryBox = new VBox ();

			//continue with login entries
			entryBox.Add (username);
			entryBox.Add (password);
			labelEntryBox.Add (usernameLabel);
			labelEntryBox.Add (passwordLabel);

			HBox loginBox = new HBox ();
			loginBox.Add (labelEntryBox);
			loginBox.Add (entryBox);

			formFrame.Add (loginBox);
			mainBox.Add (formFrame);

			//finish adding buttons
			HButtonBox commitBox = new HButtonBox ();

			Button commit = new Button ("Ok");
			Button cancel = new Button ("Cancel");
			commit.Show ();
			cancel.Show ();
			commitBox.Add (commit);
			commitBox.Add (cancel);

			mainBox.Add (commitBox);
			//buttonBoxFrame.Add (commitBox);

			this.Add (mainBox);

			//button funzionality implementation
			cancel.Clicked += new EventHandler (CancelWindowCloser);
			commit.Clicked += new EventHandler (Commit);
			//Events
			this.DeleteEvent += new DeleteEventHandler (WindowCloser);

			//last window settings
			this.SetPosition (WindowPosition.CenterAlways);
			this.ShowAll ();
		} //end of constructor

		//methods

		//events
		public static void WindowCloser(object obj, DeleteEventArgs args)
		{
			SignalArgs sa = (SignalArgs) args;
			Application.Quit();
			sa.RetVal = true;
		}

		public static void CancelWindowCloser(object obj, EventArgs args)
		{
			SignalArgs sa = (SignalArgs) args;
			Application.Quit();
			sa.RetVal = true;
		}
		public static void Commit(object obj, EventArgs args)
		{
			SignalArgs sa = (SignalArgs) args;
			//MAKE SOMETHING RELATED WITH COMMITTING LOGIN DATA
			//
			//THEN QUIT
			Application.Quit();
			sa.RetVal = true;
		}
	} //end of class
} //end of the mainspace



