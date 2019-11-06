using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public GameObject nextLevelPanel;
    private bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        nextLevelPanel.SetActive(true);
        pauseBtn.SetActive(false);
        Time.timeScale = 0;

    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        pauseBtn.SetActive(false);
        Time.timeScale = 0;

    }

    public void PausePlay()
    {
        if (isPause)
        {
            isPause = false;
            Time.timeScale = 1;
            pauseBtn.SetActive(true);
            pausePanel.SetActive(false);
        }
        else
        {
            isPause = true;
            Time.timeScale = 0;
            pauseBtn.SetActive(false);
            pausePanel.SetActive(true);

        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Home()
    {
        SceneManager.LoadScene("Home");
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
