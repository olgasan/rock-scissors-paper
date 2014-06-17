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

		[SetUp]
		public void SetUp ()
		{
			ui = new MyUITest();
			game = new Game (ui);
		}

		[Test]
		public void ListenPlayerMovements ()
		{
			ui.Selected (new Scissors ());
			Assert.IsInstanceOf <Scissors> (game.Player.Movement);
		}

		[Test]
		public void CPUSelectsAfterPlayerMovement ()
		{
			ui.Selected (new Scissors ());
			Assert.IsNotNull (game.CPU.Movement);
		}
	}
}
