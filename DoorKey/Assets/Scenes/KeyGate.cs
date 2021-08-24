using UnityEngine;
using System.Collections;

public class KeyGate : MonoBehaviour {
    void OnTriggerEnter(Collider collider){ 
        if (collider.gameObject.name == "player" && GameVariables.keyCount>0) {
            GameVariables.keyCount--;
            Destroy (gameObject);
        }
    }
}