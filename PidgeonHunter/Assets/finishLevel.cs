using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLevel : MonoBehaviour
{
    public GameObject WinCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Update()
    {
        if (WinCanvas.activeInHierarchy && Input.GetKey(KeyCode.Space))
        {
           
            SceneManager.LoadScene(2); 
        }
    }

    void OnTriggerEnter (Collider other )
    {
        if (other.tag == "Player")
        {
            WinCanvas.SetActive(true);
            other.GetComponent<Rigidbody>().mass = 10000f;

            
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }
}
