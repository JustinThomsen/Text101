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
	public class SansMethTest
	{
		[Test()]
		public void shouldTransitionToMethHeadBleedingOnButtonPressA ()
		{ 
			SansMeth sansMeth = new SansMeth();

			var state = sansMeth.handleInput (KeyCode.A);

			Assert.IsInstanceOf<MethHeadBleeding> (state);
		}

		[Test()]
		public void shouldTransitionToChokedOnBloodOnButtonPressB ()
		{
			SansMeth sansMeth = new SansMeth ();

			var state = sansMeth.handleInput (KeyCode.B);

			Assert.IsInstanceOf<ChokedOnBlood> (state);
		}

		[Test()]
		public void shouldTransitionToStabbedInEyeOnButtonPressC ()
		{
			SansMeth sansMeth = new SansMeth ();
			
			var state = sansMeth.handleInput (KeyCode.C);
			
			Assert.IsInstanceOf<StabbedInEye> (state);
		}
		[Test()]
		public void shouldStaySansMethOnButtonPressAnyOther ()
		{
			SansMeth sansMeth = new SansMeth ();

			var state = sansMeth.handleInput (KeyCode.Z);

			Assert.IsInstanceOf<SansMeth> (state);
		}
	}
}

