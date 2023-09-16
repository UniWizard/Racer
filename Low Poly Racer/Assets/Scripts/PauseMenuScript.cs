using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public static bool GameIsPaused = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        StaticClass.lvl1 = false;
        StaticClass.lvl2 = false;
        StaticClass.lvl3 = false;
        StaticClass.lvl4 = false;
    }

    public void Restart()
    {
        if(StaticClass.lvl1 == true)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level 1");
        }
        if (StaticClass.lvl2 == true)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level 2");
        }
        if (StaticClass.lvl3 == true)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level 3");
        }
        if (StaticClass.lvl4 == true)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Level 4");
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
