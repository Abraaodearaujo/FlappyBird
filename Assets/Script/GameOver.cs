using UnityEngine;
using UnityEngine.SceneManagement;

public class GamerOver : MonoBehaviour
{
    public GameObject gameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOverActive()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void Load()
    {
        SceneManager.LoadScene(1);
    }
}
