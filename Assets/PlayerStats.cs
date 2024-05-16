using UnityEngine;

public class PlayerStats
{
    public float movementSpeed = 1.5f;
    public float castingTime = 1.5f;
    public int maxHP = 100;
    public float maxMana = 50;
    public float manaRegeneration = 5;

    public int level = 1;
    public int Health = 150;
    public int xp = 0;
    

    public void LevelUp()
    {
        castingTime = castingTime - 0.1f;
        movementSpeed += 0.1f;
        maxHP += 5;
        maxMana += 2;
        manaRegeneration += 0.2f;
        level += 1;
        Debug.Log(level);
    }

    public void GainXp(int newxp) {

        xp += newxp;
        
        if(xp > level + 2.5f)
        {
            xp -= level * 3;
            LevelUp();
        }

    }


}