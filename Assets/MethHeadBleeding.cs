//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;

namespace Thomsen.FPMITAPrison
{
	public class MethHeadBleeding : State
	{
		#region State implementation
		public string printOptions ()
		{
			return "The tweaker freaks out and screams which becomes a gurgle as he bleeds profusely through the neck.  He is still struggling for the shank.  "+
				"Do you: \n\nA) Give him the shank \nB) Stab him again \nC) Stab yourself in the throat";
		}
		public State handleInput (KeyCode code)
		{
			if (code == KeyCode.A) {
				return new SansShank();
			} else if (code == KeyCode.B) {
				return new StabbedInBrain();
			} else if (code == KeyCode.C) {
				return new HoleInNeck();
			} else
				return new MethHeadBleeding();
		}
		#endregion
	}

}

