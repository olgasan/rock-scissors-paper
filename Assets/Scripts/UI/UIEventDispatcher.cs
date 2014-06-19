using UnityEngine;

public interface UIEventDispatcher
{
	event System.Action<Movement> PlayerMovementSelected;
}
