using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttributes : MonoBehaviour
{
    public int enemiesKilled;
    public Text enemiesKilledText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemiesKilledText.text = "Score: " + enemiesKilled.ToString();
    }
}
