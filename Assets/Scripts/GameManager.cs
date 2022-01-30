using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public int score = 0;
    public float enemyWaitingTime = 1f;
    public GameObject scoreText;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Game Manager is NULL");
            }
            return _instance;
        }
    }

    public void triggerScoreUpdate()
    {
        scoreText.GetComponent<TextMeshProUGUI>().SetText("Score: " + score);
        if (score < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void Awake()
    {
        _instance = this;
    }
}
