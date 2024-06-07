using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Obsticle") {
            GetComponent<PlayerMovement>().enabled = false;
            FindAnyObjectByType<GameManagerS1>().EndGame();
        }
    
    }

}
