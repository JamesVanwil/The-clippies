using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinWindow : MonoBehaviour
{
    public GameObject FullscreenImage;
    public GameObject NormalscreenImage;
    public void MinimizeFullScreen()
    {
        NormalscreenImage.SetActive(true);
        FullscreenImage.SetActive(false);
    }
}
