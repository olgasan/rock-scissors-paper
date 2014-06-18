using UnityEngine;
using System.Collections;

public class Scissors : Movement 
{
	protected override RoundResult CheckIfWins (Movement movement)
	{
		if (movement is Rock)
			return RoundResult.BWins;
		return RoundResult.AWins;
	}
}
