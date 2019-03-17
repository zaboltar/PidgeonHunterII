using UnityEngine;


public class Target : MonoBehaviour
{
    
    public AudioSource deathFX;
    public AudioSource dmgFX;
    public float health = 50f;
    public Transform spawnPosition;
    public GameObject Player;
    public int ExpToGive = 1;

    void Start ()
    {
       
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        dmgFX.Play();
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Player.GetComponent<PlayerAttributes>().enemiesKilled += 1;
        Player.GetComponent<PlayerAttributes>().AddExperienceToPlayer(ExpToGive);
        deathFX.Play();
        Destroy(gameObject);

    }

 

}