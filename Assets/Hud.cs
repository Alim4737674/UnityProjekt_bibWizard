using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hud : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text ManaText;
    public TMP_Text HealthText;
    public TMP_Text LevelText;

    public static int score = 0;
    /*public static int Level = 1;
    public static int Health = 150;*/



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerStats stats = Wizard.player.stats;
        scoreText.text = "Score: " + score;
        ManaText.text = "Mana: " + Wizard.Mana;
        HealthText.text = "Health: " + stats.Health;
        LevelText.text = "Level: " + stats.level;








    }
}
