using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<AudioManager>().DeathSound.Play();
            Time.timeScale = 0;
            FindObjectOfType<GameManager>().IsDead = true;
        }
    }
}
