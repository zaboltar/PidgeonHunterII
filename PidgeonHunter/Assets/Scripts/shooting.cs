using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    public Animator anim;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public float impactforce = 30;
    
    private float nextTimeToFire = 0f;
   // public Text bullets;
   // public int currentBullets;
    public AudioSource pistolClick;
   // private Animation weapAnim;
    public AudioSource shootFX;


    void Start ()
    {
       // currentBullets = transform.GetComponentInParent<PlayerAttributes>().currentBullets;
        anim = transform.GetComponentInChildren<Animator>();
        //weapAnim = GetComponent<Animation>();
       
    }

    void Update()
    {


        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            if (transform.GetComponentInParent<PlayerAttributes>().currentBullets > 0 )
            {
                Shoot();
            } else
            {
                pistolClick.Play();
            }
            
        }
    }

    void Shoot()
    {
        shootFX.Play();
        //weapAnim.Play();
        transform.GetComponentInParent<PlayerAttributes>().currentBullets = transform.GetComponentInParent<PlayerAttributes>().currentBullets - 1;
        StartCoroutine(ShootCheck());

        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);

            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactforce);
            }

            GameObject impactGo = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGo, 2f);

        }
    }

    IEnumerator ShootCheck ()
    {
        anim.SetBool("isShooting", true);
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("isShooting", false);
        
    }

}