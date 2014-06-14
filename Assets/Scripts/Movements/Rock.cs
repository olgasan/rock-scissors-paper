using UnityEngine;
using System.Collections;

public class Rock : Movement 
{
	public override RoundResult CheckIfWins (Movement movement)
	{
		if (movement is Paper)
			return RoundResult.BWins;
		return RoundResult.AWins;
	}
}
