using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    private void Start()
    {
        if(Data.Instance.paused)
        {
            GamePause();
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Data.Instance.paused)
            {
                GameResume();
            }
            else
            {
                GamePause();
            }
        }
    }

    public void GameResume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Data.Instance.paused = false;
    }

    void GamePause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Data.Instance.paused = true;
    }
}
