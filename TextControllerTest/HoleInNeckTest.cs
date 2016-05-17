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
using UnityEngine;
using System;

namespace Thomsen.FPMITAPrison
{
	[TestFixture()]
	public class HoleInNeckTest
	{
		[Test()]
		public void ShouldTransitionToStateStartOnButtonPressEsc ()
		{
			HoleInNeck holeInNeck = new HoleInNeck ();

			var state = holeInNeck.handleInput (KeyCode.Escape);

			Assert.IsInstanceOf<StateStart> (state);
		}

		[Test()]
		public void ShouldStayInHoleInNeckOnAnyOtherButton ()
		{
			HoleInNeck holeInNeck = new HoleInNeck ();
			
			var state = holeInNeck.handleInput (KeyCode.Z);
			
			Assert.IsInstanceOf<HoleInNeck> (state);
		}

	}
}

