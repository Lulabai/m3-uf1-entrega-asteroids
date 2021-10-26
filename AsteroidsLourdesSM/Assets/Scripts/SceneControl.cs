using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public GameObject gameOver, levelFinished;
    public GameObject jarShip;
    public int gameOverScene, levelFinishedScene;

    void Start()
    {
        gameOver.SetActive(false);
        levelFinished.SetActive(false);
    }


    void Update()
    {
        if (gameOver == null)
        {
            SceneManager.LoadScene(gameOverScene);
        }
        else if (jarShip == null)
        {
            gameOver.SetActive(true);
        }


        if (levelFinished == null)
        {
            SceneManager.LoadScene(levelFinishedScene);
        }
        else if (GameObject.FindGameObjectsWithTag("Juliaroid").Length == 0)
        {
            levelFinished.SetActive(true);
        } 
    }
}
