using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Video;

public class Interactor : MonoBehaviour
{

    interface IInteractable 
    {
        public void Interact();
    }
    private Transform InteractorSource;
    [SerializeField] private float InteractRange;

    

    void Awake()
    {
        
    }
    void OnEnable()
    {

    }

    void OnDisable()
    {

    }
    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnInteract()
    {
        Debug.Log("Interacted");
        Debug.DrawLine(this.transform.position, this.transform.position + this.transform.forward, Color.red, 2f);

        Ray r = new(InteractorSource.position, InteractorSource.forward);
        if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
        {
            if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
            {
                interactObj.Interact();
            }
        }
    }
}
