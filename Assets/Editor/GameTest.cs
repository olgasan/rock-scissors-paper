using UnityEngine;
using NUnit.Framework;
using NSubstitute;

namespace UnityTest
{

	[TestFixture]
	internal class GameTest
	{
		internal class MyUITest : IUI 
		{
			public event System.Action<Movement> PlayerMovementSelected;
			
			public void Selected (Movement movement)
			{
				if (PlayerMovementSelected != null)
					PlayerMovementSelected (movement);
			}
		}

		private Game game;
		private MyUITest ui;
		private MovementGenerator cpu;

		[SetUp]
		public void SetUp ()
		{
			ui = new MyUITest();
			cpu = new MovementGenerator ();
			game = new Game (ui, cpu);
		}

		[Test]
		public void ResultsExistsAfterPlayerSelectsMovement ()
		{
			ui.Selected (new Scissors ());
			Assert.AreNotEqual (RoundResult.Undefined, game.RoundResult);
		}

	}
}
