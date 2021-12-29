using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject GameOverText;
    public Text ScoreText;

    private int score = 0;

    void Start()
    {
        GameOverText.SetActive(false);

        ScoreText.text = "SCORE:" + score;
    }

    void Update()
    {
        //GameOverTextが表示されているとき
        if(GameOverText.activeSelf == true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Main");
            }
            
        }
    }

    public void AddScore()
    {
        score += 100;

        ScoreText.text = "SCORE:" + score;
    }

    public void GameOver()
    {
        GameOverText.SetActive(true);
    }
}
