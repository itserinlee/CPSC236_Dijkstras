using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Names: Erin Lee & Rob Farmer
Student IDs: 2364787 (Erin)
Chapman emails: elee2@chapman.edu & rofarmer@chapman.edu
Course Number and Section: 236-01
Assignment: Final Project ("PathFindingPanther")
*/


public class Main : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene(2);
    }

    public void ButtonInstructions()
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnButton(string buttonValue)
    {
        //print("ReceivedButtonPress: " + buttonValue);

        SceneManager.LoadScene(0);
    }

    public void ButtonQuit()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
