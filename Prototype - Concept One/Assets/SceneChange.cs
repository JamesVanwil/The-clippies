using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    RaycastHit hit;
    private bool canChangeScene;
    private GameObject lastHitObject;
    public Camera PlayerCamera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, PlayerCamera.transform.forward);
        GameObject currentHitObject = null;

        if (Physics.Raycast(ray, out hit))
        {
            currentHitObject = hit.collider.gameObject;
            if (currentHitObject.CompareTag("Pc") || currentHitObject.CompareTag("Phone"))
            {
                canChangeScene = true;
                if (currentHitObject != lastHitObject)
                {
                    DeactivateScript(lastHitObject);
                }
                lastHitObject = currentHitObject;
                ActivateScript(currentHitObject);
            }
            else
            {
                canChangeScene = false;
                DeactivateScript(lastHitObject);
                lastHitObject = null;
            }
        }
        else
        {
            canChangeScene = false;
            DeactivateScript(lastHitObject);
            lastHitObject = null;
        }

        if (canChangeScene && Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            if (hit.collider.CompareTag("Pc"))
            {
                SceneManager.LoadScene("PCScene");
            }
            else if (hit.collider.CompareTag("Phone"))
            {
                SceneManager.LoadScene("PhoneScene");
            }
        }
    }

    void ActivateScript(GameObject obj)
    {
        MonoBehaviour script = obj.GetComponent<MonoBehaviour>();
        if (script != null)
        {
            script.enabled = true;
        }
    }

    void DeactivateScript(GameObject obj)
    {
        if (obj != null)
        {
            MonoBehaviour script = obj.GetComponent<MonoBehaviour>();
            if (script != null)
            {
                script.enabled = false;
            }
        }
    }
}
