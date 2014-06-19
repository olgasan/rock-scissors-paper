using UnityEngine;

public interface IUIEventDispatcher
{
	event System.Action<Movement> PlayerMovementSelected;
}
