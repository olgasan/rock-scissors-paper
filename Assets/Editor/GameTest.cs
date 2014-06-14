using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class GameTest
	{
		private Game game;

		[SetUp]
		public void SetUp ()
		{
			game = new Game ();
		}
	}
}
