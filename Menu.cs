using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    //Public function that starts game when clicked//
    public void OnPlayButton ()
    {
        SceneManager.LoadScene(1);

    }
    //Public function that closes game when clicked//
    public void OnQuitButton ()
    {
        //built in Unity function//
        Application.Quit();

    }
}
