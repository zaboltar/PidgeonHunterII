using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapArsenal : MonoBehaviour
{

    public GameObject HandGun;
    public bool hasHandGun = false;
    public GameObject SecrWeap;
    public bool hasSecrWeap = false;
    public GameObject Kalashnikov;
    public bool hasKalashnikov = false;
    public GameObject ColtMFour;
    public bool hasColtMFour = false;
    public GameObject GatlingGun;
    public bool hasGatlingGun = false;
    public GameObject Shotgun;
    public bool hasShotgun = false;
    public GameObject RocketL;
    public bool hasRocketL = false;
    public GameObject Uzi;
    public bool hasUzi = false;
    public GameObject Sniper;
    public bool hasSniper = false;
    // Start is called before the first frame update
    void Start()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(false);
        Kalashnikov.SetActive(false);
        ColtMFour.SetActive(false);
        GatlingGun.SetActive(false);
        Shotgun.SetActive(false);
        RocketL.SetActive(false);
        Uzi.SetActive(false);
        Sniper.SetActive(false);

        transform.GetComponentInParent<shooting>().enabled = false;
        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0) && hasSecrWeap)
        {
            SetWeaponToSecretWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && hasHandGun)
        {
            SetWeaponToPistol();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && hasKalashnikov)
        {
            SetWeaponToKakashnikov();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && hasColtMFour)
        {
            SetWeaponToColtMfour();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && hasGatlingGun)
        {
            SetWeaponToGatlingGun();
        }

        if (Input.GetKeyDown(KeyCode.Alpha5) && hasRocketL)
        {
            SetWeaponToRocketL();
        }

        if (Input.GetKeyDown(KeyCode.Alpha6) && hasUzi)
        {
            SetWeaponToUzi();
        }

        if (Input.GetKeyDown(KeyCode.Alpha7) && hasSniper)
        {
            SetWeaponToSniper();
        }

      
    }

    public void SetWeaponToPistol()
    {
        HandGun.SetActive(true);
        SecrWeap.SetActive(false);
        Kalashnikov.SetActive(false);
        ColtMFour.SetActive(false);
        GatlingGun.SetActive(false);
        Shotgun.SetActive(false);
        RocketL.SetActive(false);
        Uzi.SetActive(false);
        Sniper.SetActive(false);


        //transform.GetComponentInParent<shooting>().enabled = true;

        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    public void SetWeaponToSecretWeapon()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(true);
        Kalashnikov.SetActive(false);
        ColtMFour.SetActive(false);
        GatlingGun.SetActive(false);
        Shotgun.SetActive(false);
        RocketL.SetActive(false);
        Uzi.SetActive(false);
        Sniper.SetActive(false);
        
        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = true;
    }

    public void SetWeaponToKakashnikov ()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(false);
        Kalashnikov.SetActive(true);
        ColtMFour.SetActive(false);
        GatlingGun.SetActive(false);
        Shotgun.SetActive(false);
        RocketL.SetActive(false);
        Uzi.SetActive(false);
        Sniper.SetActive(false);

        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    public void SetWeaponToColtMfour()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(false);
        Kalashnikov.SetActive(false);
        ColtMFour.SetActive(true);
        GatlingGun.SetActive(false);
        Shotgun.SetActive(false);
        RocketL.SetActive(false);
        Uzi.SetActive(false);
        Sniper.SetActive(false);

        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    public void SetWeaponToGatlingGun()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(false);
        Kalashnikov.SetActive(false);
        ColtMFour.SetActive(false);
        GatlingGun.SetActive(true);
        Shotgun.SetActive(false);
        RocketL.SetActive(false);
        Uzi.SetActive(false);
        Sniper.SetActive(false);

        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    public void SetWeaponToShotgun()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(false);
        Kalashnikov.SetActive(false);
        ColtMFour.SetActive(false);
        GatlingGun.SetActive(false);
        Shotgun.SetActive(true);
        RocketL.SetActive(false);
        Uzi.SetActive(false);
        Sniper.SetActive(false);

        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    public void SetWeaponToRocketL()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(false);
        Kalashnikov.SetActive(false);
        ColtMFour.SetActive(false);
        GatlingGun.SetActive(false);
        Shotgun.SetActive(false);
        RocketL.SetActive(true);
        Uzi.SetActive(false);
        Sniper.SetActive(false);

        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    public void SetWeaponToUzi()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(false);
        Kalashnikov.SetActive(false);
        ColtMFour.SetActive(false);
        GatlingGun.SetActive(false);
        Shotgun.SetActive(false);
        RocketL.SetActive(false);
        Uzi.SetActive(true);
        Sniper.SetActive(false);

        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

    public void SetWeaponToSniper()
    {
        HandGun.SetActive(false);
        SecrWeap.SetActive(false);
        Kalashnikov.SetActive(false);
        ColtMFour.SetActive(false);
        GatlingGun.SetActive(false);
        Shotgun.SetActive(false);
        RocketL.SetActive(false);
        Uzi.SetActive(false);
        Sniper.SetActive(true);

        transform.GetComponentInParent<PlayerMeleeAttack>().enabled = false;
    }

   

}
