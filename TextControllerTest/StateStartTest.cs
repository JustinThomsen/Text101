//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using NUnit.Framework; 
using System;

namespace StateStartTest 
{
	[TestFixture()]
	public class StateStartTest
	{
		[Test()]
		public void shouldTransitionToInCellOnButtonPressE ()
		{ 
			StateStart stateStart = new StateStart();

			var state = stateStart.handleInput (UnityEngine.KeyCode.E);

			Assert.IsInstanceOf<InCell> (state);
		}

		[Test()]
		public void shouldTransitionToLifeFailOnButtonPressL ()
		{
			StateStart stateStart = new StateStart();
			
			var state = stateStart.handleInput (UnityEngine.KeyCode.L);
			
			Assert.IsInstanceOf<LifeFail> (state);
		}

		[Test()]
		public void shouldTransitionToStartOnButtonPressAnyOther ()
		{
			StateStart stateStart = new StateStart();
			
			var state = stateStart.handleInput (UnityEngine.KeyCode.Z);
			
			Assert.IsInstanceOf<StateStart> (state);
		}
	}
}

