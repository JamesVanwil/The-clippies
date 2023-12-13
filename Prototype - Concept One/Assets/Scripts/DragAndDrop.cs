using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
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
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();

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
        Vector2 newPosition = rectTransform.anchoredPosition + eventData.delta / canvas.scaleFactor;
        rectTransform.anchoredPosition = ClampToCanvas(newPosition);
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
