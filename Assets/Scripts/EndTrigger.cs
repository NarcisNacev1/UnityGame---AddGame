using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManagerS1 GameManager;
    void OnTriggerEnter () {
        GameManager.CompleteLevel();
    }
}
