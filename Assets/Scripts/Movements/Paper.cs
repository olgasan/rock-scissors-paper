﻿using UnityEngine;
using System.Collections;

public class Paper  : Movement 
{
	protected override RoundResult CheckIfWins (Movement movement)
	{
		if (movement is Rock)
			return RoundResult.AWins;
		return RoundResult.BWins;
	}
}
