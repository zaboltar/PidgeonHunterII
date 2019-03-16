using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeleeAttack : MonoBehaviour
{
    public Camera cam;
    public GameObject hand;
    public SecretWeapon mySW;
    public Animator handAnim;

    public AudioSource SWAtckSFX;

    private float attackTimer;


    // Start is called before the first frame update
    void Start()
    {
      //  handAnim = hand.GetComponent<Animator>();
        mySW = hand.GetComponentInChildren<SecretWeapon>();
    }

    // Update is called once per frame
    void Update()
    {
        attackTimer += Time.deltaTime;

        if (Input.GetMouseButtonUp(0) && attackTimer >= mySW.attackCooldown)
        {
            DoAttack();
        }
    }

    public void DoAttack()
    {
        handAnim.SetBool("hasAttacked", true);
        SWAtckSFX.Play();
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray , out hit, mySW.attackRange))
        {
            if (hit.collider.tag == "Enemy")
            {
                Target eHP = hit.collider.GetComponent<Target>();
                eHP.TakeDamage(mySW.attackDamage);
            }
        }

       
    }

    public void StopAttack()
    {
        handAnim.SetBool("hasAttacked", false);
        // attackTimer = 0f;
    }
}
