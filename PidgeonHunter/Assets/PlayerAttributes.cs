using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttributes : MonoBehaviour
{

    public int currentBullets = 25;
    public Text bullets;

    public int enemiesKilled;
    public Text enemiesKilledText;
    public Text lvlTxt;
    public int currentExp;
    public int currentLvl;
    public int[] toLevelUp;
    public GameObject lvlUpMsg;
    private PlayerDamage playerDmg;

    // stat things from new character creation
    public enum Gender {Woman, Man, NonBinary};
    public Gender currentGender;

    public enum JobClass {Warrior, Shooter, Wizard};
    public JobClass currentJobClass;

    public enum PhilPers {Idealist, Rationalist, Empirist};
    public PhilPers currentPhilPers;

    public enum BonusStat {Speed, Damage, Theological}
    public BonusStat currentBonusStat;


    // Start is called before the first frame update
    void Start()
    {
        playerDmg = FindObjectOfType<PlayerDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        bullets.text = "Bullets: " + currentBullets.ToString();

        if (currentExp >= toLevelUp[currentLvl])
        {
            currentLvl++;
            lvlUpMsg.SetActive(true);
            playerDmg.PlayerMaxHealth += 10;
            playerDmg.PlayerHealth = playerDmg.PlayerMaxHealth;

        }

        enemiesKilledText.text = "Score: " + enemiesKilled.ToString();

        lvlTxt.text = "Lvl: "+currentLvl.ToString();
    
    }

    public void AddExperienceToPlayer(int expToAdd)
    {
        currentExp += expToAdd;
    }
}
