using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Oxygen : MonoBehaviour {

	public Transform spaceShip;
	public float oxygenLevel;
	public Text oxygenText;
    public Slider oxygenSlider;

	// Determines the distance between the player a object that will determine
	// whether they are able to be in the oxygen zone or not. 
	float DistanceCalc(){
			float dist = Vector3.Distance (spaceShip.position, transform.position);
			return dist;
	}
		

	// Use this for initialization
	void Start () {
        oxygenSlider.value = 100;
	}
	
	// Update is called once per frame
	void Update () {

		if (DistanceCalc () >= 40.0) {
			oxygenLevel = oxygenLevel - (float) .005;
		}

        oxygenSlider.value = oxygenLevel;

        oxygenText.text = oxygenLevel.ToString("n2") + "%";

		//percentage = (decimal.Divide(oxygenLevel, initialOxygenLevel)); 
		//oxygenText.text = "Oxygen Level: " + percentage.ToString("P");


		if (oxygenLevel < 0) {
			// Game Over. 
		}


	}
}
