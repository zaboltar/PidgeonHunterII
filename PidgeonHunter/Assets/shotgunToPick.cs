using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgunToPick : MonoBehaviour
{
    public AudioSource pickUpFx;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToShotgun();
            pickUpFx.Play();
            other.GetComponentInChildren<WeapArsenal>().hasShotgun = true;
            Destroy(gameObject);
        }
    }
}
