using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerUnit : NetworkBehaviour
{
    // note: rigidbody sync is a "hairy" topic .... -.- !!!

    // Start is called before the first frame update
    void Start()
    {
        
    }

    Vector3 velocity;
    Vector3 bestGuessPosition;
    float ourLatency;
    float latencySmoothingFactor = 10;

    // Update is called once per frame<z
    void Update()
    {
        if (hasAuthority == false) 
        {
            bestGuessPosition = bestGuessPosition + (velocity * Time.deltaTime);
            transform.position= Vector3.Lerp(transform.position, bestGuessPosition, Time.deltaTime*latencySmoothingFactor);
            return;
        }

        transform.Translate(velocity * Time.deltaTime);

        /* if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.Translate(0,1,0);
        }*/

         if (Input.GetKeyDown(KeyCode.K))
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            velocity = new Vector3 (1,0,0);
            CmdUpdateVelocity(velocity, transform.position);
        }
    }

    [Command]
    void CmdUpdateVelocity(Vector3 v, Vector3 p)
    {
        transform.position = p;
        velocity = v;
        RpcUpdateVelocity(velocity, transform.position);
    }

    [ClientRpc]
    void RpcUpdateVelocity(Vector3 v, Vector3 p)
    {
        if (hasAuthority)
        {
            return;
        }

        //transform.position = p;
        velocity = v;
        bestGuessPosition = p + (velocity * (ourLatency));
        
    }
}
