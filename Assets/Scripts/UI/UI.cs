using UnityEngine;
using System.Collections;

public class UI : UIEventDispatcher 
{
	public event System.Action<Movement> PlayerMovementSelected;

	public void Selected (Movement movement)
	{
		if (PlayerMovementSelected != null)
			PlayerMovementSelected (movement);
	}

}
