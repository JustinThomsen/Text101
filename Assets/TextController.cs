using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

namespace Thomsen.FPMITAPrison
{
	public interface State {

		String printOptions();
		State handleInput(KeyCode code);
	}

	public class TextController : MonoBehaviour {

		public Text text;
		private enum States {stabSelf, giveShank, throatAgain, start, live, escape, meth, throat, taint, eye, hang, shankSelf};
		private KeyCode code;
		private KeyCode emptyCode;
		private State currentState;


		void Start () {
			currentState = new StateStart ();
		}

		void Update () {

			text.text = currentState.printOptions();
			currentState = currentState.handleInput (code);
			code = emptyCode;

			if (Input.GetKeyDown(KeyCode.Escape)) {
				code = KeyCode.Escape;
			}
			if (Input.GetKeyDown(KeyCode.L)) {
				code = KeyCode.L;
			}
			if (Input.GetKeyDown(KeyCode.E)) {
				code = KeyCode.E;
			}
			if (Input.GetKeyDown(KeyCode.A)) {
				code = KeyCode.A;
			}
			if (Input.GetKeyDown(KeyCode.B)) {
				code = KeyCode.B;
			}
			if (Input.GetKeyDown(KeyCode.C)) {
				code = KeyCode.C;
			}
		}
	}
}