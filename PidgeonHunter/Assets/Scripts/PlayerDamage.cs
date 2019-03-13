using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;

public class PlayerDamage : MonoBehaviour
{
    public GameObject deathCanvas;
    public int PlayerHealth = 30;
    int damage = 10;
    public Transform target;
    public Rigidbody myRBwtf;


    void Start()
    {
        print(PlayerHealth);
        myRBwtf = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag == "bullet")
        {
            PlayerHealth -= damage;
            if (PlayerHealth <= 0)
            {


               // transform.position = target.position;
                if (PlayerHealth <= 0)
                {
                    Die();
                    
                }
            }
                        
        }
                     
    }

    void Die ()
    {
       deathCanvas.SetActive(true);
       myRBwtf.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (PlayerHealth <= 0)
        {
            PlayerHealth = 30;
        }
    }

}