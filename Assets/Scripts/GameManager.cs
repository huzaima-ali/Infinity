using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public Button RestartButton;
    public GameObject GameOverScreen;
    public GameObject PauseButton;
    public GameObject DistanceDisplay;
    public GameObject TitleScreen;
    // Start is called before the first frame update
    public void StartGame()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {   
        isGameActive = false;
        GameOverScreen.gameObject.SetActive(true);
        RestartButton.gameObject.SetActive(true);
        PauseButton.gameObject.SetActive(false);
        DistanceDisplay.gameObject.SetActive(false);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PauseButton.gameObject.SetActive(true);
        DistanceDisplay.gameObject.SetActive(true);
    }

}
