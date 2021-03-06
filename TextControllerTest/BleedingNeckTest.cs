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
using UnityEngine;

namespace Thomsen.FPMITAPrison
{
	[TestFixture()]
	public class BleedingNeckTest
	{
		[Test()]
		public void shouldTransitionToStateStartOnButtonPressEsc ()
		{ 
			BleedingNeck bleedingNeck = new BleedingNeck();

			var state = bleedingNeck.handleInput (KeyCode.Escape);

			Assert.IsInstanceOf<StateStart> (state);
		}

		[Test()]
		public void shouldStayInBleedingNeckOnButtonPressAnyOther ()
		{
			BleedingNeck bleedingNeck = new BleedingNeck();
			
			var state = bleedingNeck.handleInput (KeyCode.Z);
			
			Assert.IsInstanceOf<BleedingNeck> (state);
		}
	/*	[Test()]
		public void shouldStayInStartOnNoButtonPress()
		{
			StateStart stateStart = new StateStart();
			//KeyCode can't be null
			//I dont think we need to do this- we can just assert the way it is
			//What this is saying is that the action is actually no action
			//I cant think of how else to do this.
			var state = stateStart.handleInput(null);
			
			Assert.IsInstanceOf<StateStart> (start);
		}*/
	}
}

