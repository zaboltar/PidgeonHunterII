using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperToPick : MonoBehaviour
{
    public AudioSource pickUpFx;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToSniper();
            pickUpFx.Play();
            other.GetComponentInChildren<WeapArsenal>().hasSniper = true;
            Destroy(gameObject);
        }
    }
}
