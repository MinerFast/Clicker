using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GameManager : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        scoreText.SetText("Money: " + score);
    }

    public void Money()
    {
        addMoney(4);
        scoreText.SetText("Money: " + score);
    }
    private void Update()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();

    }
    public void nextScene()
    {
        SceneManager.LoadScene("Scene2");
    }
    public int addMoney(int coins)
    {
        score += coins;
        return score;
    }
}
