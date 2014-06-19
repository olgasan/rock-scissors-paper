using UnityEngine;
using System.Collections;

public class UIScoreDisplayer : ScoreDisplayer
{
	public string PlayerScoreLabel 
	{
		get;
		private set;
	}

	public void UpdatePlayerScore (int score)
	{
		PlayerScoreLabel = score.ToString ();
	}

	public void UpdateCPUScore (int score)
	{

	}
}
