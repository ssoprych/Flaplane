using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void Update()
    {
        transform.position += Vector3.left * (2f * Time.deltaTime);
    }

}
