using UnityEngine;
using System.Collections;

public class UIObject : MonoBehaviour 
{
	private UIEventDispatcher ui;
	private OnScreenDebugMenu menu;

	private void Awake ()
	{
		menu = new OnScreenDebugMenu ();
		ui = new UIEventDispatcher ();
	}

	private void OnGUI ()
	{
		menu.Reset ();
		if (menu.DrawButton ("Rock"))
		{
			ui.Selected (new Rock ());
		}

		if (menu.DrawButton ("Scissors"))
		{
			ui.Selected (new Scissors ());
		}

		if (menu.DrawButton ("Paper"))
		{
			ui.Selected (new Paper ());
		}
	}
}
