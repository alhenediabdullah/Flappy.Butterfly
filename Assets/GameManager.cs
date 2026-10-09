using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject startMenuUI;
    public GameObject difficultyMenuUI;
    public GameObject scoreUI;
    public GameObject menuBackground;
    public GameObject butterfly;
    public GameObject pipeSpawner;
    public GameObject diffMenuBack;


    public static float gameSpeed = 2f;
    public static float pipeGap = 3f;
    public static float spawnRate = 2f; 

    void Start()
    {
        Time.timeScale = 0f;
        startMenuUI.SetActive(true);
        menuBackground.SetActive(true);
        difficultyMenuUI.SetActive(false);
        scoreUI.SetActive(false);
        butterfly.SetActive(false);
        pipeSpawner.SetActive(false);
    }

    public void ShowDifficultyMenu()
    {
        startMenuUI.SetActive(false);
        difficultyMenuUI.SetActive(true);
        diffMenuBack.SetActive(true);
    }

    public void SetEasyDifficulty()
    {
        gameSpeed = 8f;
        pipeGap = 0f;
        spawnRate = 3.3f; 
        StartActualGame();
    }

    public void SetHardDifficulty()
    {
        gameSpeed = 8.5f;   
        pipeGap = 2.4f;   
        spawnRate = 2.2f; 
        StartActualGame();
    }

    private void StartActualGame()
    {
        difficultyMenuUI.SetActive(false);
        menuBackground.SetActive(false);
        diffMenuBack.SetActive(false);
        Time.timeScale = 1f;
        scoreUI.SetActive(true);
        butterfly.SetActive(true);
        pipeSpawner.SetActive(true);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}