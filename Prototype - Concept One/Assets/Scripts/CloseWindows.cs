using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CloseWindows : MonoBehaviour, IPointerClickHandler
{
    //public Image imageToDeactivate;

    // Implement the click handler
    public void OnPointerClick(PointerEventData eventData)
    {
        // Check if the image to deactivate is not null
        //if (imageToDeactivate != null)
        {
            // Deactivate the specified image
            //imageToDeactivate.gameObject.SetActive(false);
            transform.parent.gameObject.SetActive(false);
        }
    }
}
