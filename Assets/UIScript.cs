using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Button startButton;
    public Button quitButton;
    public GameObject panel;
    public GameObject oxygenLevelUI;
    public GameObject pieceItemText;
    public GameObject inventoryText;

	// Use this for initialization
	void Start () {

        panel = GameObject.Find("startUIPanel");
        oxygenLevelUI = GameObject.Find("OxygenUI");
        pieceItemText = GameObject.Find("pieceCountText");
        inventoryText = GameObject.Find("inventoryText");

        inventoryText.SetActive(false);
        pieceItemText.SetActive(false);
        oxygenLevelUI.SetActive(false);
        

        Button startBtn = startButton.GetComponent<Button>();
        Button quitBtn = quitButton.GetComponent<Button>();

        startBtn.onClick.AddListener(startButtonOnClick);
        quitBtn.onClick.AddListener(quitButtonOnClick);


    }

    private void quitButtonOnClick()
    {
        Application.Quit();
    }

    private void startButtonOnClick()
    {
        inventoryText.SetActive(true);
        pieceItemText.SetActive(true);
        oxygenLevelUI.SetActive(true);
        panel.SetActive(false);
        //Console.WriteLine("Start Button");
    }

    // Update is called once per frame
    void Update () {
		
	}


}
