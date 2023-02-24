using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathButObstacle : MonoBehaviour
{
    public AudioClip DeathSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySound(DeathSound);
            Time.timeScale = 0;
            Singleton.Instance.IsDead = true;
        }
    }
}
