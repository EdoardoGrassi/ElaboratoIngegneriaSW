using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	//private Label labelDiProva2;
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Label labelDiProva = new Label ("Questo è un label di prova.");
		//Button bottoneDiProva = new Button ("bottone");
		this.Add (labelDiProva);
		this.ShowAll ();
		this.DeleteEvent += new DeleteEventHandler (OnDeleteEvent);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
