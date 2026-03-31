using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private GameObject StartScreen;
    [SerializeField] private GameObject EndScreen;
    [SerializeField] private Button restartButton;
    private bool isStarted = false;

    private void Awake()
    {
        Instance = this;
        StartScreen.SetActive(true);
        EndScreen.SetActive(false);
        Time.timeScale = 0;
        restartButton.onClick.AddListener(ReplayGame);
    }

    private void Update()
    {
        if (isStarted==false)
        {
            StartScreen.SetActive(true);
        }
        if (Input.GetButtonDown("Fire1") && isStarted==false)
        {
            StartScreen.SetActive(false);
            isStarted = true;
            Time.timeScale = 1f;
        }    
    }

    public void GameOver()
    {
        EndScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    private void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
