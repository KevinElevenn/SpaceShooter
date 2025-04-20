using UnityEngine;

public class TestInteractionScript : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("Interacted! Random number: " + Random.Range(0, 100));
    }
}
