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
            //other.GetComponentInChildren<WeapArsenal>().SetWeaponToPistol();
            other.GetComponent<PlayerAttributes>().currentBullets = other.GetComponent<PlayerAttributes>().currentBullets + 40;
            bulletPick.Play();
            Destroy(gameObject);
        }
    }
}
