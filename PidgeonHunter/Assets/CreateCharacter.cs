using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCharacter : MonoBehaviour
{
    public GameObject createCharPanel;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public Text AttributesSummary;
    string gender;
    string jobClass;
    string philoPers;
    string bonus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AttributesSummary.text = "Gender: " + gender + "\n" + "Class: " + jobClass + "\n" + "Mind: " + philoPers + "\n" + "Bonus: " + bonus;
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
        gender = "Woman";
    }

    public void SetGenderToMan()
    {
        panel2.SetActive(true);
        panel1.SetActive(false);
        gender = "Man";
    }

    public void SetGenderToNonBinary()
    {
        panel2.SetActive(true);
        panel1.SetActive(false);
        gender = "NonBinary";
    }

    // panel2

    public void SetPlayerClassToWarrior()
    {
        panel3.SetActive(true);
        panel2.SetActive(false);
        jobClass = "Warrior";
    }

    public void SetPlayerClassToShooter()
    {
        panel3.SetActive(true);
        panel2.SetActive(false);
        jobClass = "Shooter";
    }

    public void SetPlayerClassToWizard()
    {
        panel3.SetActive(true);
        panel2.SetActive(false);
        jobClass = "Wizard";
    }

    // panel3

    public void SetPhilosophicalPerspectiveToIdealist()
    {
        panel4.SetActive(true);
        panel3.SetActive(false);
        philoPers = "Idealist";
    }

    public void SetPhilosophicalPerspectiveToRationalist()
    {
        panel4.SetActive(true);
        panel3.SetActive(false);
        philoPers = "Rationalist";
    }

    public void SetPhilosophicalPerspectiveToEmpirist()
    {
        panel4.SetActive(true);
        panel3.SetActive(false);
        philoPers = "Empirist";
    }

    // panel4

    public void SetBonusSpeed()
    {
        panel5.SetActive(true);
        panel4.SetActive(false);
        bonus = "Speed";
    }

    public void SetBonusDamage()
    {
        panel5.SetActive(true);
        panel4.SetActive(false);
        bonus = "Damage";
    }

    public void SetBonusTheological()
    {
        panel5.SetActive(true);
        panel4.SetActive(false);
        bonus = "Theological";
    }
}
