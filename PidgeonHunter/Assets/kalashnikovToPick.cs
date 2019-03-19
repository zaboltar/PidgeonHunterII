using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kalashnikovToPick : MonoBehaviour
{
    public AudioSource pickUpFx;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToKakashnikov();
            pickUpFx.Play();
            other.GetComponentInChildren<WeapArsenal>().hasKalashnikov = true;
            Destroy(gameObject);
        }
    }
}
