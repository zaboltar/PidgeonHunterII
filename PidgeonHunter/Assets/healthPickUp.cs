using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickUp : MonoBehaviour
{
    public AudioSource healPlayerSFX;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerDamage>().PlayerHealth = other.GetComponent<PlayerDamage>().PlayerHealth + 40;
            if (other.GetComponent<PlayerDamage>().PlayerHealth >= other.GetComponent<PlayerDamage>().PlayerMaxHealth)
            {
                other.GetComponent<PlayerDamage>().PlayerHealth = other.GetComponent<PlayerDamage>().PlayerMaxHealth;
            }


            healPlayerSFX.Play();
            Destroy(gameObject);
        }
    }
  
}