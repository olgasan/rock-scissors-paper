using UnityEngine;
using NUnit.Framework;
using NSubstitute;

namespace UnityTest
{

	[TestFixture]
	internal class GameTest
	{
		internal class MyUITest : UIEventDispatcher 
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
			cpu = Substitute.For <MovementGenerator> ();
			cpu.GenerateMovement ().Returns (new Rock ());
			game = new Game (ui, cpu);
		}

		[Test]
		public void CountPlayerWins ()
		{
			cpu.GenerateMovement ().Returns (new Paper ());
			ui.Selected (new Scissors ());

			cpu.GenerateMovement ().Returns (new Paper ());
			ui.Selected (new Scissors ());

			cpu.GenerateMovement ().Returns (new Scissors ());
			ui.Selected (new Paper ());

			Assert.AreEqual (2, game.PlayerScore);
		}

		[Test]
		public void CountCPUWins ()
		{
			cpu.GenerateMovement ().Returns (new Scissors ());
			ui.Selected (new Paper ());
			
			cpu.GenerateMovement ().Returns (new Scissors ());
			ui.Selected (new Paper ());
			
			Assert.AreEqual (2, game.CPUScore);
		}

		[Test]
		public void TiesDontAffectsScore ()
		{
			cpu.GenerateMovement ().Returns (new Scissors ());
			ui.Selected (new Scissors ());
			
			Assert.AreEqual (0, game.PlayerScore);
			Assert.AreEqual (0, game.CPUScore);
		}
	}
}
