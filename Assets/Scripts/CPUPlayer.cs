using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CPUPlayer : Player
{
	private List<Movement> availableMovements;

	public CPUPlayer ()
	{
		availableMovements = new List<Movement> () {
			new Rock (),
			new Scissors (),
			new Paper ()
		};
	}

	public void SelectMovement ()
	{
		int random = Random.Range (0, availableMovements.Count-1);
		Movement = availableMovements[random];
	}
}
