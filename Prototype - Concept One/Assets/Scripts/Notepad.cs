using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notepad : MonoBehaviour
{

    public string TheText;
    public GameObject ourNote;
    public GameObject placeHolder;

    


    private void Start()
    {
        
        // Check if placeHolder is assigned and has an InputField component
        if (placeHolder != null)
        {
            InputField inputField = placeHolder.GetComponent<InputField>();
            if (inputField != null)
            {
                TheText = PlayerPrefs.GetString("NoteContents");
                inputField.text = TheText;
            }
            else
            {
                Debug.LogError("InputField component not found on placeHolder GameObject.");
            }
        }
        else
        {
            Debug.LogError("placeHolder GameObject not assigned.");
        }
    }

    public void SaveNotes()
    {
        TheText = ourNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("NoteContents", TheText);
        PlayerPrefs.Save();
    }
}
