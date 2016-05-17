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
		private States myState;

		// Use this for initialization
		void Start () {
			myState = States.start;
		}
		// Update is called once per frame
		void Update () {
			if (myState == States.start) {
				myState = state_start();
			} else if (myState == States.escape) {
				myState = state_escape();
			} else if (myState == States.throatAgain) {
				myState = state_throatAgain();
			} else if (myState == States.live) {
				myState = state_live();
			} else if (myState == States.meth) {
				myState = state_meth();
			} else if (myState == States.throat) {
				myState = state_throat();
			} else if (myState == States.hang) {
				myState = state_hang();
			} else if (myState == States.stabSelf) {
				myState = state_stabSelf();
			} else if (myState == States.giveShank) {
				myState = state_giveShank();
			} else if (myState == States.shankSelf) {
				myState = state_shankSelf();
			} else if (myState == States.eye) {
				myState = state_eye();
			} else if (myState == States.taint) {
				myState = state_taint();
			}
		}
		States state_escape() {
			text.text = "What would you like to do? \n\nPress \"A\" to give your meth-head cellmate all the meth. \nPress \"B\" to shank yourself and call for help.  " +
				"\nPress \"C\" to hang yourself with your towel.";
			if (Input.GetKeyDown (KeyCode.A)){
				return States.meth;
			}
			if (Input.GetKeyDown (KeyCode.B)){
				return States.shankSelf;
			}
			if (Input.GetKeyDown (KeyCode.C)){
				return States.hang;
			}
			return States.escape;
		}
		States state_live() {
			text.text = "You go through the motions, serve your prison sentence and are released on good behavior.  You are not a useful member of society anymore.  Good job breaking the law."+
				"\n\nPress Escape to start over.";
			if (Input.GetKeyDown (KeyCode.Escape)) {
				return States.start;
			} else
				return States.live;
		}
		States state_throat() {
			text.text = "The tweaker freaks out and screams which becomes a gurgle as he bleeds profusely through the neck.  He is still struggling for the shank.  "+
				"Do you: \n\nA) Give him the shank \nB) Stab him again \nC) Stab yourself in the throat";
			if (Input.GetKeyDown (KeyCode.A)) {
				return States.giveShank;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				return States.throatAgain;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				return States.stabSelf;
			} else 
				return States.throat;
		}
		States state_giveShank() {
			text.text = "You hand your cellmate the shank just as the guards show up to investigate.  The guards see what is happening, and decide to let him die and kill you too.  You die."+
				"\n\nPress Escape to start over.";
			if (Input.GetKeyDown (KeyCode.Escape)) {
				return States.start;
			} else
				return States.giveShank;
		}
		States state_shankSelf() {
			text.text = "You stab yourself in the neck, throw the shank down, and call for help.  The guards come, see the bloody shank, and decide to let you die.  You die."+
				"\n\nPress Escape to start over.";
			if (Input.GetKeyDown (KeyCode.Escape)) {
				return States.start;
			} else
				return States.shankSelf;
		}
		States state_taint() {
			text.text = "As you duck down for an uppercut stab to the taint, the tweaker punches you in the face and you miss the taint but slice his femoral artery. "+
				"You get sprayed in the face with so much blood that you start choking on the blood.  You die.\n\nPress Escape to start over.";
			if (Input.GetKeyDown (KeyCode.Escape)) {
				return States.start;
			} else
				return States.taint;
		}
		States state_eye() {
			text.text = "You aim for the tweaker's eye and miss, stabbing yourself in the eye.  You die, and the tweaker eats your face. \n\nPress Escape to start over.";
			if (Input.GetKeyDown (KeyCode.Escape)) {
				return States.start;
			} else 
				return States.eye;
		}
		States state_hang() {
			text.text = "You die with a dirty towel around your neck and the tweaker steals your meth. \n\nPress Escape to start over.";
			if (Input.GetKeyDown (KeyCode.Escape)) {
				return States.start;
			} else
				return States.hang;
		}
		States state_throatAgain() {
			text.text = "You try to stab the tweaker again and slip and fall on the knife, which stabs you in the brain.  You die. \n\nPress Escape to start over.";
			if (Input.GetKeyDown (KeyCode.Escape)) {
				return States.start;
			} else 
				return States.throatAgain;
		}
		States state_start() {
			text.text = "Welcome to federal pound me in the ass prison.  You can either try to escape, or safely live out your days as " +
						"an upstanding federal prisoner. You have in your possession a prison shank, a towel and a bunch of meth. \n\n" +
						"Press \"E\" try to escape.\nPress \"L\" to live out your sentence.";

			if (Input.GetKeyDown (KeyCode.E)){
				return States.escape;
			}
			if (Input.GetKeyDown (KeyCode.L)) {
				return States.live;
			} 
			else
				return States.start;
		}
		States state_meth() {
			text.text = "Your meth-head cellmate starts tweaking hardcore and tries to steal your prison shank.  Do you: \n\nA) Stab him in the throat "+
				"\nB) Stab him in the taint \nC) Stab him in the eye";
			if (Input.GetKeyDown (KeyCode.A)) {
				return States.throat;
			} else if (Input.GetKeyDown (KeyCode.B)) {
				return States.taint;
			} else if (Input.GetKeyDown (KeyCode.C)) {
				return States.eye;
			} else
				return States.meth;
		}
		States state_stabSelf() {
			text.text = "You die from a giant hole in your neck. \n\nPress Escape to start over.";
			if (Input.GetKeyDown (KeyCode.Escape)) {
				return States.start;
			} else
				return States.stabSelf;
		}
	}
}