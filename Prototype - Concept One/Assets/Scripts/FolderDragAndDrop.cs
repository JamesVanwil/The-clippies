using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FolderDragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;

    void Start()
    {
        // Get the RectTransform, Canvas, and CanvasGroup components
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();

        // Ensure the CanvasGroup exists
        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
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
        Vector2 newPosition = rectTransform.anchoredPosition + eventData.delta / canvas.scaleFactor;
        rectTransform.anchoredPosition = ClampToCanvas(newPosition);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Set the object back to interactable
        canvasGroup.blocksRaycasts = true;
    }


    // Clamp the position to stay within the canvas boundaries
    private Vector2 ClampToCanvas(Vector2 position)
    {
        float canvasWidth = canvas.GetComponent<RectTransform>().sizeDelta.x;
        float canvasHeight = canvas.GetComponent<RectTransform>().sizeDelta.y;

        // Calculate the clamped position
        position.x = Mathf.Clamp(position.x, -canvasWidth / 2f, canvasWidth / 2f);
        position.y = Mathf.Clamp(position.y, -canvasHeight / 2f, canvasHeight / 2f);

        return position;
    }
}
