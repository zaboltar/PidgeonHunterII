using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolPick : MonoBehaviour
{
    public AudioSource pickPistolSFX;
   

    void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToPistol();
            pickPistolSFX.Play();
            other.GetComponentInChildren<WeapArsenal>().hasHandGun = true;
            Destroy(gameObject);
        }
    }
}
