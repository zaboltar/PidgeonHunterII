﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour
{
    public AudioSource deathFX;
    public GameObject deathCanvas;
    public int PlayerMaxHealth = 50;
    public int PlayerHealth;
    int damage = 10;
    public Transform target;
    public Slider hpBar;
    public Text hpText;
    public AudioSource hurtSFX;

    void Start()
    {
        PlayerHealth = PlayerMaxHealth;
        hpBar.maxValue = PlayerMaxHealth;
        
    }

    void Update ()
    {
        
        hpBar.value = PlayerHealth;
        hpBar.maxValue = PlayerMaxHealth;

        if (PlayerHealth <= 0)
        {
            Die();
        }

        hpText.text = "HP: " + PlayerHealth + " / " + PlayerMaxHealth;
    }

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.tag == "bullet")
        {
            PlayerHealth -= 5;
            hurtSFX.Play();
            Destroy(_collision.gameObject);
                        
        }
                     
    }

    void Die ()
    {
        deathFX.Play();
       deathCanvas.SetActive(true);
       gameObject.SetActive(false);
    }

   

}