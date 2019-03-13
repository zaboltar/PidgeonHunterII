using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public GameObject deathCanvas;
    public int PlayerMaxHealth = 50;
    public int PlayerHealth;
    int damage = 10;
    public Transform target;
    public Slider hpBar;


    void Start()
    {
        PlayerHealth = PlayerMaxHealth;
        hpBar.maxValue = PlayerMaxHealth;
        
    }

    void Update ()
    {
        hpBar.value = PlayerHealth;

        if (PlayerHealth <= 0)
        {
            Die();
        }
    }

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag == "bullet")
        {
            PlayerHealth -= damage;
           /* if (PlayerHealth <= 0)
            {


               // transform.position = target.position;
                if (PlayerHealth <= 0)
                {
                    Die();
                    
                }
            }*/
                        
        }
                     
    }

    void Die ()
    {
       deathCanvas.SetActive(true);
       gameObject.SetActive(false);
    }

   

}