using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{

    public InputSystem_Actions playerControls;
    public Transform InteractorSource;
    public float InteractRange;

    private InputAction interact;

    void Awake()
    {
        playerControls = new InputSystem_Actions();
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
        
        Ray r = new(InteractorSource.position, InteractorSource.forward);
        if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
        {
            if (hitInfo.collider.gameObject.TryGetCompnent(out IInteractable interactObj))
            {
                interactObj.Interact();
            }
        }
    }
}
