using System;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] Transform spavnPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            spavnPoint.position = transform.position;
        }
    }
}
