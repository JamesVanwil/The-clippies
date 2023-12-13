using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Bin : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        // Get the dragged object
        GameObject draggedObject = eventData.pointerDrag;

        // Check if the dragged object has an Image component
        Image draggedImage = draggedObject.GetComponent<Image>();

        // If the dragged object has an Image component, delete it and its children
        if (draggedImage != null)
        {
            // Destroy the GameObject of the dragged item and its children
            Destroy(draggedObject);
        }
    }
}
