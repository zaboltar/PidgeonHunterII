using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapArsenal : MonoBehaviour
{

    public GameObject HandGun;
    public GameObject SecrWeap;

    // Start is called before the first frame update
    void Start()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(false);
        transform.GetComponentInParent<shooting>().enabled = false;
        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetWeaponToSecretWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetWeaponToPistol();
        }
    }

    public void SetWeaponToPistol()
    {
        HandGun.SetActive(true);
        SecrWeap.SetActive(false);

        transform.GetComponentInParent<shooting>().enabled = true;

        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    public void SetWeaponToSecretWeapon()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(true);
        transform.GetComponentInParent<shooting>().enabled = false;
        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = true;
    }
}
