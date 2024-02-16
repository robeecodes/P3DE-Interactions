using UnityEngine;

public class GetTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Triggered!");
        Debug.Log(other.gameObject.name);
    }
}
