using UnityEngine;

public class Game  
{
	private MovementGenerator movementGenerator;
	private ScoreDisplayer displayer;

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

	public Game (IUIEventDispatcher ui, ScoreDisplayer displayer, MovementGenerator cpu)
	{
		ui.PlayerMovementSelected += OnPlayerMovementSelected;
		movementGenerator = cpu;
		this.displayer = displayer;
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
		{
			PlayerScore++;
			displayer.UpdatePlayerScore (PlayerScore);
		}
		else if (result == RoundResult.BWins)
		{
			CPUScore++;
			displayer.UpdateCPUScore (CPUScore);
		}
	}
}
