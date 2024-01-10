using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorScene1;
    public Texture2D cursorScene2;

    private void Awake()
    {
        // Ensure that this GameObject (and the script) won't be destroyed when a new scene is loaded
        DontDestroyOnLoad(gameObject);

        // Register the method to be called when the scene is changed
        SceneManager.sceneLoaded += OnSceneLoaded;

        // Set the initial cursor based on the first loaded scene
        SetCursorTexture();
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Change cursor texture when a new scene is loaded
        SetCursorTexture();
    }

    private void SetCursorTexture()
    {
        // Get the current scene name
        string currentScene = SceneManager.GetActiveScene().name;

        // Set the cursor based on the current scene
        if (currentScene == "PcScene")
        {
            SetCursor(cursorScene1);
        }
        else if (currentScene == "PhoneScene")
        {
            SetCursor(cursorScene2);
        }
        // Add more conditions for additional scenes
    }

    private void SetCursor(Texture2D cursorTexture)
    {
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }

}
