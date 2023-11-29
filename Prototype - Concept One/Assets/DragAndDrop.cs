using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;

    // Reference to the second image
    public GameObject secondImage;

    void Start()
    {
        // Get the RectTransform, Canvas, and CanvasGroup components
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();

        // Ensure the CanvasGroup exists
        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }

        // Deactivate the second image at the start
        if (secondImage != null)
        {
            secondImage.SetActive(false);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Set the object as being dragged
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Move the object with the mouse/finger
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Set the object back to interactable
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Toggle the visibility of the second image when the first image is clicked
        if (secondImage != null)
        {
            secondImage.SetActive(!secondImage.activeSelf);
        }
    }
}
