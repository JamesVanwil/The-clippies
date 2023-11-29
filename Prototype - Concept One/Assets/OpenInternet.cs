using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OpenInternet : MonoBehaviour, IPointerClickHandler
{
    public Image imageToToggle; // Reference to the image you want to appear/disappear

    void Start()
    {
        // Ensure the image is initially disabled
        imageToToggle.gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Toggle the visibility of the image
        imageToToggle.gameObject.SetActive(true);
    }
}
