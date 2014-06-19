using UnityEngine;

public class Game  
{
	private MovementGenerator movementGenerator;

	public int PlayerScore 
	{
		get;
		private set;
	}

	public int CPUScore 
	{
		get;
		private set;
	}

	public Game (IUI ui, MovementGenerator cpu)
	{
		ui.PlayerMovementSelected += OnPlayerMovementSelected;
		movementGenerator = cpu;
	}

	private void OnPlayerMovementSelected (Movement movementInstance)
	{
		Movement cpuMovement = movementGenerator.GenerateMovement ();
		RoundResult result = movementInstance.GetResult (cpuMovement);

		UpdateScore (result);
	}

	private void UpdateScore (RoundResult result)
	{
		if (result == RoundResult.AWins)
			PlayerScore++;
		else if (result == RoundResult.BWins)
			CPUScore++;
	}
}
