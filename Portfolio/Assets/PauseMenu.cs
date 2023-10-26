using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
                Resume();
            else
                Paused();
        }
    }

    public void Paused()
    {
        pauseMenuUI.SetActive(true);
        gameIsPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        gameIsPaused = false;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }
}
