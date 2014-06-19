using UnityEngine;
using NUnit.Framework;
using NSubstitute;

namespace UnityTest
{

	[TestFixture]
	internal class GameTest
	{
		internal class MyUITest : IUIEventDispatcher 
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
		private ScoreDisplayer displayer;

		[SetUp]
		public void SetUp ()
		{
			ui = new MyUITest();
			displayer = Substitute.For <ScoreDisplayer> ();

			cpu = Substitute.For <MovementGenerator> ();
			cpu.GenerateMovement ().Returns (new Rock ());

			game = new Game (ui, displayer, cpu);
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

		[Test]
		public void CallUIDisplayerWhenPlayerWinsRound ()
		{
			cpu.GenerateMovement ().Returns (new Paper ());
			ui.Selected (new Scissors ());

			displayer.Received().UpdatePlayerScore (1);
		}

		[Test]
		public void CallUIDisplayerWhenCPUWinsRound ()
		{
			cpu.GenerateMovement ().Returns (new Scissors ());
			ui.Selected (new Paper ());
			
			displayer.Received().UpdateCPUScore (1);
		}
	}
}
