using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{

    RaycastHit hit;
    private bool canChangeScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            canChangeScene = true;
        } else
        {
            canChangeScene = false;
        }

        if (canChangeScene && Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            SceneManager.LoadScene(1);
        }
    }
}
