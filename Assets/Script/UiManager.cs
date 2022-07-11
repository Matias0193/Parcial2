using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    GameManager gm;
    public GameObject pauseMenuObject;
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseGame();
        }
    }
    public void PauseGame()
    {
        gm.isPaused = !gm.isPaused;
        if (gm.isPaused)
        {
            Time.timeScale = 0;
            pauseMenuObject.SetActive(true);
        }
        else
        {
            pauseMenuObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
