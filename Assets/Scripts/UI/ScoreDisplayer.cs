using UnityEngine;
using System.Collections;

public interface ScoreDisplayer
{
	void UpdatePlayerScore (int score);
	void UpdateCPUScore (int score);
}
