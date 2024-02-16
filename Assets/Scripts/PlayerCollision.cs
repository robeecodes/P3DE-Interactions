using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.name == "Wall") {
            Debug.Log("It's a hit!");
        }
    }
}
