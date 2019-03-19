using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uziToPick : MonoBehaviour
{
    public AudioSource pickUpFx;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToUzi();
            pickUpFx.Play();
            other.GetComponentInChildren<WeapArsenal>().hasUzi = true;
            Destroy(gameObject);
        }
    }
}
