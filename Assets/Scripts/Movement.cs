using UnityEngine;
using System.Collections;

public abstract class Movement 
{
	public RoundResult GetResult (Movement movement)
	{
		if (movement.GetType() == GetType())
			return RoundResult.Tie;
		else
			return CheckIfWins(movement);
	}

	protected abstract RoundResult CheckIfWins(Movement movement);
}
