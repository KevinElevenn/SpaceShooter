using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Video;

public class Interactor : MonoBehaviour
{
    [SerializeField] private float _interactRange;
    [SerializeField] private LayerMask _interactableLayer;

private void OnInteract()
{
    Debug.Log("Interaction Key Pressed");
    Debug.DrawLine(this.transform.position, this.transform.position + this.transform.forward * _interactRange, Color.red);

    Ray ray = new Ray(transform.position, transform.forward);
    RaycastHit hit;

    if (Physics.Raycast(ray, out hit, _interactRange, _interactableLayer))
    {
        Debug.Log("Interacted with: " + hit.collider.name + " on layer " + LayerMask.LayerToName(hit.collider.gameObject.layer));

        // Try to get the IInteractable interface from the hit object
        IInteractable interactable = hit.collider.GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactable.Interact();
        }
    }
}


}
