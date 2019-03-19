using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGunToPick : MonoBehaviour
{
    public AudioSource pickUpFx;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToGatlingGun();
            pickUpFx.Play();
            other.GetComponentInChildren<WeapArsenal>().hasGatlingGun = true;
            Destroy(gameObject);
        }
    }
}
