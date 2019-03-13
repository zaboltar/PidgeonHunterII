using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickUp : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerDamage>().PlayerHealth = other.GetComponent<PlayerDamage>().PlayerHealth + 40;
            Destroy(gameObject);
        }
    }
  
}