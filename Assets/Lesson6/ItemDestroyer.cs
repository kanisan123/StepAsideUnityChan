using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CarTag") || other.CompareTag("TrafficConeTag") || other.CompareTag("CoinTag"))
        {
            Destroy(other.gameObject);
        }
    }
}
