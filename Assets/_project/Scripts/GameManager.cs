using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score;
    [SerializeField] private TMP_Text _score_text;
    [SerializeField] private GameObject ScoreText;
    public GameObject DeathScreen;
    public bool IsDead;
    private void Start()
    {
        ScoreText.SetActive(true);
        Time.timeScale = 1;
        Score = 0;
        IsDead = false;
    }
    private void Update()
    {
        _score_text.text = Score.ToString();
        if (IsDead)
        {
            DeathScreen.SetActive(true);
            if (Score > PlayerPrefs.GetInt("HighScore", 0))
            {    
                PlayerPrefs.SetInt("HighScore", Score);
                FindObjectOfType<DeathScreen>()._bestScore.text = Score.ToString();
            }
            ScoreText.SetActive(false);

        }
    }
}
