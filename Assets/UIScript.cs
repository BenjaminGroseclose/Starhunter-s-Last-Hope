using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Button startButton;
    public Button quitButton;
    public GameObject panel;

	// Use this for initialization
	void Start () {

        /*
         * Button btn = yourButton.GetComponent<Button>();
         * btn.onClick.AddListener(TaskOnClick);
         */
        panel = GameObject.Find("startUIPanel");

        Button startBtn = startButton.GetComponent<Button>();
        Button quitBtn = quitButton.GetComponent<Button>();

        startBtn.onClick.AddListener(startButtonOnClick);
        quitBtn.onClick.AddListener(quitButtonOnClick);


    }

    private void quitButtonOnClick()
    {
        panel.SetActive(false);
    }

    private void startButtonOnClick()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
		
	}


}
