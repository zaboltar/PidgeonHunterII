using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketLToPick : MonoBehaviour
{
    public AudioSource pickUpFx;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToRocketL();
            pickUpFx.Play();
            other.GetComponentInChildren<WeapArsenal>().hasRocketL = true;
            Destroy(gameObject);
        }
    }
}
