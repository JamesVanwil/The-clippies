using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OpenSearchBar : MonoBehaviour
{
    // Reference to the image you want to show/hide
    public GameObject imageToShow;
    public GameObject Fb;
    public GameObject Gmail;
    public GameObject Insta;

    // Start is called before the first frame update
    void Start()
    {

        Fb.SetActive(false);
        Gmail.SetActive(false);
        Insta.SetActive(false);
        imageToShow.SetActive(false);
        
    }

    public void OpenSearch()
    {
        imageToShow.SetActive(true);
    }

    public void OpenFb()
    {
        Fb.SetActive(true);
    }

    public void OpenGmail()
    {
        Gmail.SetActive(true);
    }

    public void OpenInsta()
    {
        Insta.SetActive(true);
    }
}
