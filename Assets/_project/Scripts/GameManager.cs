using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score;
    [SerializeField] private TMP_Text _score_text;
    private void Start()
    {
        Score = 0;
    }
    private void Update()
    {
        _score_text.text = ""+Score;
    }
}
