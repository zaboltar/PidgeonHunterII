using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour
{

    public int PlayerHealth = 30;
    int damage = 10;
    public Transform target;

    void Start()
    {
        print(PlayerHealth);
    }

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag == "bullet")
        {
            PlayerHealth -= damage;
            if (PlayerHealth <= 0)
            {


                transform.position = target.position;
                if (PlayerHealth <= 0)
                {
                    Application.LoadLevel(Application.loadedLevel);
                    //just restart lvl otherwise

                }
            }



        }




    }

    private void Update()
    {
        if (PlayerHealth <= 0)
        {
            PlayerHealth = 30;
        }
    }

}