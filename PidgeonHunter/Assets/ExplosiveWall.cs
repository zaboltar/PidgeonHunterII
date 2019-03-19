using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveWall : MonoBehaviour
{

    public GameObject wallToDestroy;
    public AudioSource explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                explosion.Play();
                transform.GetChild(1).gameObject.SetActive(true);
                Destroy(wallToDestroy.gameObject, 1f);
                Destroy(gameObject, 1f);
            }
        }
    }
}
