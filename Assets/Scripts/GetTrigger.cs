using UnityEngine;

public class GetTrigger : MonoBehaviour {
    [SerializeField] private GameObject ball;

    private int _counter;

    private void Start() {
        _counter = 0;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "PlayerArmature") {
            Destroy(ball);
        }

        _counter++;
        Debug.Log($"Player has walked through {_counter} times.");
    }
}
