using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public GameObject piece1;
    public GameObject piece2;
    public GameObject piece3;
    public GameObject piece4;
    public GameObject piece5;
    public GameObject piece6;

    public GameObject piece1Text;
    public GameObject piece2Text;
    public GameObject piece3Text;
    public GameObject piece4Text;
    public GameObject piece5Text;
    public GameObject piece6Text;

    public int pieceReturn;

    public Text piecesItemText;

    public bool piece1Bool;
    public bool piece2Bool;
    public bool piece3Bool;
    public bool piece4Bool;
    public bool piece5Bool;
    public bool piece6Bool;

    public GameObject victoryScreen;
    public Button victoryRestartButton;
    public Button victoryQuitButton;
        
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name.Contains("piece"))
        {
            //instructionText.SetActive(true);
            //if (Input.GetKeyDown(KeyCode.X))
           // {
                Debug.Log("Objects Name:" + collision.gameObject.name);
                switch (collision.gameObject.name)
                {
                    case "Windsheild_piece1":
                        Destroy(collision.gameObject);
                        piece1Text.SetActive(true);                       
                    break;
                    case "Gun_Strut 3_piece2":
                        Destroy(collision.gameObject);
                        piece2Text.SetActive(true);
                    break;
                    case "Engine_Main_1_piece3":
                        Destroy(collision.gameObject);
                        piece3Text.SetActive(true);
                    break;
                    case "Engine_Strut_piece4":
                        Destroy(collision.gameObject);
                        piece4Text.SetActive(true);
                    break;
                    case "Ring_Strut 2_piece5":
                        Destroy(collision.gameObject);
                        piece5Text.SetActive(true);
                    break;
                    case "Faring_Uper_Rear_piece6":
                        Destroy(collision.gameObject);
                        piece6Text.SetActive(true);
                    break;


                    default:
                        // Does nothing
                        break;
                        
                }
           // }
        }

        if(collision.gameObject.name == "Faring_Lower_Nose")
        {
            if (GameObject.Find("Windsheild_piece1") == null && piece1Bool == false)
            {
                piece1Bool = true;
                pieceReturn = pieceReturn + 1;
                piecesItemText.text = pieceReturn + "/6 Pieces Returned";
                piece1Text.SetActive(false);
            }
            if (GameObject.Find("Gun_Strut 3_piece2") == null && piece2Bool == false)
            {
                piece2Bool = true;
                pieceReturn = pieceReturn + 1;
                piecesItemText.text = pieceReturn + "/6 Pieces Returned";
                piece2Text.SetActive(false);
            }
            if (GameObject.Find("Engine_Main_1_piece3") == null && piece3Bool == false)
            {
                piece3Bool = true;
                pieceReturn = pieceReturn + 1;
                piecesItemText.text = pieceReturn + "/6 Pieces Returned";
                piece3Text.SetActive(false);
            }
            if (GameObject.Find("Engine_Strut_piece4") == null && piece4Bool == false)
            {
                piece4Bool = true;
                pieceReturn = pieceReturn + 1;
                piecesItemText.text = pieceReturn + "/6 Pieces Returned";
                piece4Text.SetActive(false);
            }
            if (GameObject.Find("Ring_Strut 2_piece5") == null && piece5Bool == false)
            {
                piece5Bool = true;
                pieceReturn = pieceReturn + 1;
                piecesItemText.text = pieceReturn + "/6 Pieces Returned";
                piece5Text.SetActive(false);
            }
            if (GameObject.Find("Faring_Uper_Rear_piece6") == null && piece6Bool == false)
            {
                piece6Bool = true;
                pieceReturn = pieceReturn + 1;
                piecesItemText.text = pieceReturn + "/6 Pieces Returned";
                piece6Text.SetActive(false);
            }

        }

    }

    private void OnCollisionExit(Collision collision)
    {

    }

    void Start () {

        inventorySetup();
        victoryScreen = GameObject.Find("Canvas4");
        victoryScreen.SetActive(false);

    }

    void inventorySetup()
    {
        piece1 = GameObject.Find("Windsheild_piece1");
        piece2 = GameObject.Find("Gun_Strut 3_piece2");
        piece3 = GameObject.Find("Engine_Main_1_piece3");
        piece4 = GameObject.Find("Engine_Strut_piece4");
        piece5 = GameObject.Find("Ring_Strut 2_piece5");
        piece6 = GameObject.Find("Faring_Uper_Rear_piece6");        

        piece1Text = GameObject.Find("windShieldText");
        piece2Text = GameObject.Find("rocketText");
        piece3Text = GameObject.Find("engineText");
        piece4Text = GameObject.Find("wingText");
        piece5Text = GameObject.Find("ringStrutText");
        piece6Text = GameObject.Find("bodyText");

        piece1Text.SetActive(false);
        piece2Text.SetActive(false);
        piece3Text.SetActive(false);
        piece4Text.SetActive(false);
        piece5Text.SetActive(false);
        piece6Text.SetActive(false);
    }
    

    // Update is called once per frame
	void Update () {
		if(pieceReturn == 6)
        {

            victoryScreen.SetActive(true);

            Button restartBtn = victoryRestartButton.GetComponent<Button>();
            Button quitBtn = victoryQuitButton.GetComponent<Button>();

            restartBtn.onClick.AddListener(restartGame);
            quitBtn.onClick.AddListener(quitGame);

        }
	}

    private void quitGame()
    {
        Application.Quit();
    }

    private void restartGame()
    {
        pieceReturn = 0;
        Application.LoadLevel(Application.loadedLevel);
    }
}
