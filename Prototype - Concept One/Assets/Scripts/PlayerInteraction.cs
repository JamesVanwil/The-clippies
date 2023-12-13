using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    RaycastHit hit;
    private bool canChangeScene;
    public Camera PlayerCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, PlayerCamera.transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
           
            if (hit.collider.CompareTag("Pc"))
            {
                canChangeScene = true;
            }
          
            else if (hit.collider.CompareTag("Phone"))
            {
                canChangeScene = true;
                
            }
            else
            {
                canChangeScene = false;
            }
        }
        else
        {
            canChangeScene = false;
        }

        if (canChangeScene && Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

          
            if (hit.collider.CompareTag("Pc"))
            {
                SceneManager.LoadScene(2);
            }
            else if (hit.collider.CompareTag("Phone"))
            {
                SceneManager.LoadScene(3);
              
            }
        }
    }
}
