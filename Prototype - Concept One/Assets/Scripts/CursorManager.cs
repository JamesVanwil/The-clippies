using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorScene1;
    public Texture2D cursorScene2;

    public bool showCursor = true;

    private void Start()
    {

        Cursor.visible = showCursor;
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        
        SceneManager.sceneLoaded += OnSceneLoaded;

       
        SetCursorTexture();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
      
        SetCursorTexture();
    }

    private void SetCursorTexture()
    {
       
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "PcScene")
        {
            SetCursor(cursorScene1);
        }
        else if (currentScene == "PhoneScene")
        {
            SetCursor(cursorScene2);
        }
       
    }

   
    private void SetCursor(Texture2D cursorTexture)
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }


}
