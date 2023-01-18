using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Obstacle;
    public Transform ObstacleSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            var position = new Vector3(10, Random.Range(-2f, 3f), 0);
            Instantiate(Obstacle, position, ObstacleSpawn.transform.rotation);
        }
    }
}
