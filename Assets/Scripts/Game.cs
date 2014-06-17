using UnityEngine;

public class Game  
{
	public RoundResult RoundResult 
	{
		get;
		private set;
	}

	public Player Player 
	{
		get;
		private set;
	}

	public CPUPlayer CPU 
	{
		get;
		private set;
	}

	public Game (IUI ui)
	{
		ui.PlayerMovementSelected += OnPlayerMovementSelected;
		Player = new Player ();
		CPU = new CPUPlayer ();
	}

	private void OnPlayerMovementSelected (Movement movementInstance)
	{
		Player.Movement = movementInstance;
		CPU.SelectMovement ();
	}
}
