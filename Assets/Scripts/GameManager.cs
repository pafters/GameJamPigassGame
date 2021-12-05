using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

   

    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true); 
    }
    public void Replay()
    {
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
