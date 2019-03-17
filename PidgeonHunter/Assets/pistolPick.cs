using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistolPick : MonoBehaviour
{
    public AudioSource pickPistolSFX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Player")
        {
            other.GetComponentInChildren<WeapArsenal>().SetWeaponToPistol();
            pickPistolSFX.Play();
            Destroy(gameObject);
        }
    }
}
