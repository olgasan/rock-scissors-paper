using UnityEngine;

public class Game  
{
	public RoundResult RoundResult 
	{
		get;
		private set;
	}

	public MovementGenerator CPU 
	{
		get;
		private set;
	}

	public Game (IUI ui, MovementGenerator cpu)
	{
		RoundResult = RoundResult.Undefined;
		ui.PlayerMovementSelected += OnPlayerMovementSelected;
		CPU = cpu;
	}

	private void OnPlayerMovementSelected (Movement movementInstance)
	{
		 Movement cpuMovement = CPU.GenerateMovement ();
		RoundResult = movementInstance.GetResult (cpuMovement);
	}
}
