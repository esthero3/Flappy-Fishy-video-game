using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    // method to load the next scene
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    //Takes player back to Main Menu
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        // FindObjectOfType
        FindObjectOfType<GameSession>().ResetScore();
    }

    //Replays the game
    public void Replay()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<GameSession>().ResetScore();
    }

    //quits game
    public void QuitGame()
    {
        Application.Quit();
    }
}
