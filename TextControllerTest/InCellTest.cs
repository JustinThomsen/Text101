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

namespace Thomsen.FPMITAPrison 
{
	[TestFixture()]
	public class InCellTest
	{
		[Test()]
		public void shouldTransitionToSansMethOnButtonPressA ()
		{ 
			InCell inCell = new InCell();

			var state = inCell.handleInput (UnityEngine.KeyCode.A);

			Assert.IsInstanceOf<SansMeth> (state);
		}

		[Test()]
		public void shouldTransitionToBleedingNeckOnButtonPressB ()
		{
			InCell inCell = new InCell();
			
			var state = inCell.handleInput (UnityEngine.KeyCode.B);
			
			Assert.IsInstanceOf<BleedingNeck> (state);
		}

		[Test()]
		public void shouldTransitionToHangingDeadOnButtonPressC ()
		{
			InCell inCell = new InCell();
			
			var state = inCell.handleInput (UnityEngine.KeyCode.C);
			
			Assert.IsInstanceOf<HangingDead> (state);
		}
		[Test()]
		public void shouldStayInCellOnButtonPressAnyOther ()
		{
			InCell inCell = new InCell();

			var state = inCell.handleInput (UnityEngine.KeyCode.Z);

			Assert.IsInstanceOf<InCell> (state);
		}
	}
}

