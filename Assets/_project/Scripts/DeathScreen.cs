using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text _deathScore;
    public TMP_Text _bestScore;

    private void Start()
    {
        _deathScore.text = Singleton.Instance.Score.ToString();
        _bestScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
