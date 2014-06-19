using UnityEngine;
using NUnit.Framework;

namespace UnityTest
{
	[TestFixture]
	internal class UITest
	{
		private UIEventDispatcher ui;
		private int eventCount;

		[SetUp]
		public void SetUp ()
		{
			eventCount = 0;
			ui = new UIEventDispatcher ();
			ui.PlayerMovementSelected += OnPlayerMovementSelected;
		}

		[Test]
		public void TriggerEventWhenUserSelectsAMovement ()
		{
			ui.Selected (new Rock ());
			Assert.AreEqual (1, eventCount);
		}

		private void OnPlayerMovementSelected (Movement movementInstance)
		{
			eventCount ++;
		}
	}
}
