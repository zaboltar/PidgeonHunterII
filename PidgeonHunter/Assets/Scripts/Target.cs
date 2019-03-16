using UnityEngine;

public class Target : MonoBehaviour
{
    public AudioSource deathFX;
    public float health = 50f;
    public Transform spawnPosition;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        deathFX.Play();
        Destroy(gameObject);




    }

}