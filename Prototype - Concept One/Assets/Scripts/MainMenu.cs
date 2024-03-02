using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    
    public void Play()
    {
        SceneManager.LoadScene(6);
    }

    public void Help()
    {
        SceneManager.LoadScene(7);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }


    public void BackTo3DView()
    {
      
        SceneManager.LoadScene("3DView");

    }
}
