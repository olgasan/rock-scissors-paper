using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class MovementTest
	{
		[Test]
		public void ScissorsBeatsPaper ()
		{
			Scissors s = new Scissors();
			Assert.AreEqual(RoundResult.AWins, s.GetResult(new Paper()));
		}

		[Test]
		public void PaperLosesToScissors ()
		{
			Paper p = new Paper();
			Assert.AreEqual(RoundResult.BWins, p.GetResult(new Scissors()));
		}

		[Test]
		public void PaperBeatsRock ()
		{
			Paper p = new Paper();
			Assert.AreEqual(RoundResult.AWins, p.GetResult(new Rock()));
		}

		[Test]
		public void RockLosesToPaper ()
		{
			Rock p = new Rock();
			Assert.AreEqual(RoundResult.BWins, p.GetResult(new Paper()));
		}

		[Test]
		public void RockBeatsScissors ()
		{
			Rock p = new Rock();
			Assert.AreEqual(RoundResult.AWins, p.GetResult(new Scissors()));
		}

		[Test]
		public void ScissorsLosesToRock ()
		{
			Scissors p = new Scissors();
			Assert.AreEqual(RoundResult.BWins, p.GetResult(new Rock()));
		}

		[Test]
		public void SameMovementIsATie ()
		{
			Scissors p = new Scissors();
			Assert.AreEqual(RoundResult.Tie, p.GetResult(new Scissors()));
		}
	}
}
