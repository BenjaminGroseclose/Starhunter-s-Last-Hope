using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Oxygen : MonoBehaviour {

	public Transform other;
	public int oxygenLevel;
	public int initialOxygenLevel;
	public Text oxygenText;

	// Determines the distance between the player a object that will determine
	// whether they are able to be in the oxygen zone or not. 
	float DistanceCalc(){
			float dist = Vector3.Distance (other.position, transform.position);
			return dist;
	}
		

	// Use this for initialization
	void Start () {
		initialOxygenLevel = oxygenLevel;
	}
	
	// Update is called once per frame
	void Update () {
		decimal percentage;

		if (DistanceCalc () >= 40.0) {
			oxygenLevel = oxygenLevel - 1;
		}

		percentage = (decimal.Divide(oxygenLevel, initialOxygenLevel)); 
		oxygenText.text = "Oxygen Level: " + percentage.ToString("P");


		if (oxygenLevel < 0) {
			// Game Over. 
		}


	}
}
