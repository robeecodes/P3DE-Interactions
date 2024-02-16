using System;
using UnityEngine;
using UnityEngine.Serialization;

public class GetTrigger : MonoBehaviour {
    [SerializeField] private int score;
    
    private void Start() {
        score = 0;
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log($"Triggered by {other.gameObject.name}");
        score++;
        Debug.Log(score);
    }
}
