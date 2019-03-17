using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCharacter : MonoBehaviour
{
    public GameObject createCharPanel;
    public GameObject panel1;
    public GameObject panel2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCreateCharPanel()
    {
        createCharPanel.SetActive(true);
        panel1.SetActive(true);
    }

    // panel 1 

    public void SetGenderToWoman ()
    {
        panel2.SetActive(true);
        panel1.SetActive(false);
    }

    public void SetGenderToMan()
    {
        panel2.SetActive(true);
        panel1.SetActive(false);
    }

    public void SetGenderToNonBinary()
    {
        panel2.SetActive(true);
        panel1.SetActive(false);
    }


}
