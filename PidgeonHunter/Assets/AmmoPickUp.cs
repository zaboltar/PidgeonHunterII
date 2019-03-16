using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    public AudioSource bulletPick;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<shooting>().currentBullets = other.GetComponent<shooting>().currentBullets + 10;
            bulletPick.Play();
            Destroy(gameObject);
        }
    }
}
