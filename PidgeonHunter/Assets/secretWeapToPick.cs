using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secretWeapToPick : MonoBehaviour
{
    public AudioSource chickFX;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToSecretWeapon();
            chickFX.Play();
            Destroy(gameObject);
        }
    }
}
