using UnityEngine;
using System.Collections;

public class UIObject : MonoBehaviour 
{
	private UI ui;
	private OnScreenDebugMenu menu;

	private void Awake ()
	{
		menu = new OnScreenDebugMenu ();
		ui = new UI ();
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
