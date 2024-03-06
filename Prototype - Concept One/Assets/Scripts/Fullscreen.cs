using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{

    public GameObject FullscreenImage;
    public GameObject Browser;
    public GameObject NormalscreenImage;
    // Start is called before the first frame update
    void Start()
    {
        FullscreenImage.SetActive(false);
    }

    public void SetFullScreen()
    {
        FullscreenImage.SetActive(true);
        NormalscreenImage.SetActive(false);
    }

    public void OpenBrowser()
    {
        Browser.SetActive(true);
    }
}
