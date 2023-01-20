using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathButObstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().DeathSound.Play();
            Time.timeScale = 0;
            FindObjectOfType<GameManager>().IsDead = true;
        }
    }
}
