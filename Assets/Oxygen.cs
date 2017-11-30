using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System;
using UnityEngine.SceneManagement;

public class Oxygen : MonoBehaviour {

	public Transform spaceShip;
	public float oxygenLevel;
	public Text oxygenText;
    public Slider oxygenSlider;

    public Button restartButton;
    public Button quitButton2;
    public GameObject gameOverPanel;
    public int useCount;

	// Determines the distance between the player a object that will determine
	// whether they are able to be in the oxygen zone or not. 
	float DistanceCalc(){
			float dist = Vector3.Distance (spaceShip.position, transform.position);
			return dist;
	}
		

	// Use this for initialization
	void Start () {
        oxygenSlider.value = 100;

        gameOverPanel = GameObject.Find("Canvas3");

        gameOverPanel.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.X) && useCount != 1)
        {
            if (oxygenLevel <= 90) oxygenLevel = oxygenLevel + 10;
            else oxygenLevel = oxygenLevel + (100 - oxygenLevel);
            useCount = 1;
        }

		if (DistanceCalc () >= 41.0) {
			oxygenLevel = oxygenLevel - (float) .005;
		}

        oxygenSlider.value = oxygenLevel;

        oxygenText.text = oxygenLevel.ToString("n2") + "%";

		//percentage = (decimal.Divide(oxygenLevel, initialOxygenLevel)); 
		//oxygenText.text = "Oxygen Level: " + percentage.ToString("P");


		if (oxygenLevel <= 0) {
            gameOverPanel.SetActive(true);


            Button restartBtn = restartButton.GetComponent<Button>();
            Button quitBtn2 = quitButton2.GetComponent<Button>();

            restartBtn.onClick.AddListener(restartButtonOnClick);
            quitBtn2.onClick.AddListener(quitButton2OnClick);

        }


	}

    private void restartButtonOnClick()
    {
        oxygenLevel = 100;
        SceneManager.LoadScene("Starhunter's Last Hope");
    }

    private void quitButton2OnClick()
    {
        Application.Quit();
    }
}
