using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovementGenerator
{
	private List<Movement> availableMovements;

	public MovementGenerator ()
	{
		availableMovements = new List<Movement> () {
			new Rock (),
			new Scissors (),
			new Paper ()
		};
	}

	public Movement GenerateMovement ()
	{
		int random = Random.Range (0, availableMovements.Count-1);
		return availableMovements[random];
	}
}
