using UnityEngine;
using System.Collections;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class UIScoreDisplayerTest
	{
		[Test]
		public void UpdatesPlayerScore ()
		{
			UIScoreDisplayer displayer = new UIScoreDisplayer ();
			displayer.UpdatePlayerScore (20);

			Assert.AreEqual ("20", displayer.PlayerScoreLabel);
		}
	}
}
