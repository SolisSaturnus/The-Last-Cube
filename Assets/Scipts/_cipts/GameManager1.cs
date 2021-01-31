
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour {


    bool gameHasEnded = false;

    public float resartDelay = 1f;

    public GameObject completeLevelUI;


    public void Completelevel()

    {
        completeLevelUI.SetActive(true);

    }

    public void EndGame ()

    {
        if (gameHasEnded == false)
        {

            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", resartDelay);
            // RESTART GAME
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
 
}
