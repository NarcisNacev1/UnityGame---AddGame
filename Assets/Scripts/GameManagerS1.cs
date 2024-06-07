using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerS1 : MonoBehaviour {

    bool GameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame() {
        if (GameHasEnded == false) {
            GameHasEnded = true;
            Debug.Log("Game over");// restaring of game 
            Invoke("Restart", restartDelay);
        }
    }

    private void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
