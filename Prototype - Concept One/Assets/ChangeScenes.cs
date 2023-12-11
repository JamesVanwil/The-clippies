using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public bool isPcScene = false;
    public bool isPhoneScene = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPcScene)
            {
                isPhoneScene = true;
                isPcScene = false;
                SceneManager.LoadScene("PhoneScene");
            }
            else if (isPhoneScene)
            {
                isPhoneScene = false;
                isPcScene = true;
                SceneManager.LoadScene("PcScene");
            }

        }
        
      

    }
}
