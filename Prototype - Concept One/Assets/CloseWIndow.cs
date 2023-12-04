using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CloseWindow : MonoBehaviour, IPointerClickHandler
{
    public Image imageToDeactivate;
    public Image imageToToggleFullScreen;

    private bool isFullScreen = false;
    private Vector2 originalSize;
    private Vector3 originalPosition;

    // Implement the click handler
    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the image to deactivate is not null
        if (imageToDeactivate != null)
        {
            // Deactivate the specified image
            imageToDeactivate.gameObject.SetActive(false);
        }

        // Toggle fullscreen state for the second image
        if (imageToToggleFullScreen != null)
        {
            ToggleFullScreen(imageToToggleFullScreen);
        }
    }

    // Function to toggle fullscreen for the given image
    private void ToggleFullScreen(Image image)
    {
        // Toggle fullscreen state
        isFullScreen = !isFullScreen;

        // Set the image to either fullscreen or normal size based on the current state
        RectTransform rt = image.GetComponent<RectTransform>();

        if (isFullScreen)
        {
            // Store the original size and position if not done already
            if (originalSize == Vector2.zero)
            {
                originalSize = rt.sizeDelta;
                originalPosition = rt.anchoredPosition3D;
            }

            // Calculate the desired size and position to fill the entire screen
            Vector2 screenSize = new Vector2(Screen.width, Screen.height);
            rt.sizeDelta = screenSize;
            rt.anchoredPosition = screenSize / 2f;
        }
        else
        {
            // Restore original size and position
            rt.sizeDelta = originalSize;
            rt.anchoredPosition3D = originalPosition;
        }
    }
}
