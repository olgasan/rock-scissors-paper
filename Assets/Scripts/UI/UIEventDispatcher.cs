using UnityEngine;
using System.Collections;

public class UIEventDispatcher : IUIEventDispatcher 
{
	public event System.Action<Movement> PlayerMovementSelected;

	public void Selected (Movement movement)
	{
		if (PlayerMovementSelected != null)
			PlayerMovementSelected (movement);
	}

}
