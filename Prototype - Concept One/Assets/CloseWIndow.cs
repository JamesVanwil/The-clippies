using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CloseWindow : MonoBehaviour, IPointerClickHandler
{
    public Image imageToDeactivate;

    public Image imageToToggleFullScreen;

    private bool isFullScreen = false;


    // Implement the click handler
    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the image to deactivate is not null
        if (imageToDeactivate != null)
        {
            // Deactivate the specified image
            imageToDeactivate.gameObject.SetActive(false);
        }


        // Check if the image to toggle fullscreen is not null
        if (imageToToggleFullScreen != null)
        {
            // Toggle fullscreen for the specified image
            ToggleFullScreen(imageToToggleFullScreen);
        }


    }


    // Function to toggle fullscreen for the given image
    private void ToggleFullScreen(Image image)
    {
        // Toggle fullscreen state
        isFullScreen = !isFullScreen;

        if (isFullScreen)
        {
            // Set the rect transform size to fill the screen
            RectTransform rt = image.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(Screen.width, Screen.height);

            // Set the image position to the center of the screen
            rt.position = new Vector3(Screen.width / 2, Screen.height / 2, rt.position.z);
        }
        else
        {
            // Restore original size and position
            RectTransform rt = image.GetComponent<RectTransform>();
            // Set the original size
            rt.sizeDelta = new Vector2(1174, 528);

            // Set the original position
            rt.position = new Vector3(1300, 750, rt.position.z);
        }
    }


}