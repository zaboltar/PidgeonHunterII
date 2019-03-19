using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coltToPick : MonoBehaviour
{
    public AudioSource pickUpFx;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToColtMfour();
            pickUpFx.Play();
            other.GetComponentInChildren<WeapArsenal>().hasColtMFour = true;
            Destroy(gameObject);
        }
    }
}
