using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance ;
    public bool gameRunning;
    [SerializeField] int playArea = 32;
    [SerializeField] int timeLimit = 60;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI gameOverText;
    [SerializeField] Button restartButton;
    // Start is called before the first frame update
    private void Awake() {
        //Create public reference for Gamemanager
        Instance = this;
    }

    void Start()
    {
        //Start Game
        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        gameRunning = true;
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown(){
        //Count time until game is over
        int time = timeLimit;
        while(time > 0){
            timeText.text = "Time: " + time;
            yield return new WaitForSeconds(1f);
            time--; 
        }
        gameRunning = false;
        timeText.text = "Time is up!";
        GameOver();
    }

    void GameOver(){
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public int getPlayArea(){
        return playArea;
    }
}
