using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class MovementGeneratorTest
	{
		[Test]
		public void GeneratesRandomMovement ()
		{
			MovementGenerator cpu = new MovementGenerator ();
			Movement generatedMovement = cpu.GenerateMovement ();

			Assert.IsNotNull (generatedMovement);
			Assert.IsInstanceOf <Movement> (generatedMovement);
		}
	}
}
