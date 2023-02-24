using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _score_text;
    [SerializeField] private GameObject ScoreText;
    public GameObject DeathScreen;
    public AudioClip GameMusic;

    private void Start()
    {
        ScoreText.SetActive(true);
        Time.timeScale = 1;
        Singleton.Instance.Score = 0;
        Singleton.Instance.IsDead = false;
        AudioManager.Instance.PlayMusic(GameMusic);
    }
    private void Update()
    {
        _score_text.text = Singleton.Instance.Score.ToString();
        if (Singleton.Instance.IsDead)
        {
            AudioManager.Instance.StopMusic(GameMusic);
            DeathScreen.SetActive(true);
            if (Singleton.Instance.Score > PlayerPrefs.GetInt("HighScore", 0))
            {    
                PlayerPrefs.SetInt("HighScore", Singleton.Instance.Score);
                FindObjectOfType<DeathScreen>()._bestScore.text = Singleton.Instance.Score.ToString();
            }
            ScoreText.SetActive(false);

        }
    }
}
