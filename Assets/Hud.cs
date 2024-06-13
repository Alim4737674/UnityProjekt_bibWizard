using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text ManaText;
    public TMP_Text HealthText;
    public TMP_Text LevelText;
    public static string Text;


    public static int score = 0;

    public Image HealthImage;
    public Image ManaImage;
    public Image LevelImage;


    /*public static int Level = 1;
    public static int Health = 150;*/



    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Wizard w = Wizard.player;
        PlayerStats s = w.stats;
        float maxMana = s.maxMana;
        int maxHP = s.maxHP;
        int displayMana = (int)w.mana;

        Hud.Text = "Score: " + score;
        scoreText.text = Hud.Text;
        HealthText.text = "Health: " + w.hp + "|" + maxHP;
        ManaText.text = "Mana: " + displayMana + "|" + maxMana;
        LevelText.text = "Level: " + s.level;



        float healthPercentage = (float)w.hp / (float)maxHP;
        HealthImage.transform.localScale = new Vector3(healthPercentage * 1.47f, 1.155f, 1);

        float ManaPercentage = (float)w.mana / (float)maxMana;
        ManaImage.transform.localScale = new Vector3(ManaPercentage * 1.47f, 1.155f, 1);

        


    }
}


