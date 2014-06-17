using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class CPUPlayerTest
	{
		[Test]
		public void GeneratesRandomMovement ()
		{
			CPUPlayer cpu = new CPUPlayer ();
			cpu.SelectMovement ();

			Assert.IsNotNull (cpu.Movement);
			Assert.IsInstanceOf <Movement> (cpu.Movement);
		}
	}
}
