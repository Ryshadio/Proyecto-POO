using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer : Unit
{

    public int heal;
    public override bool TakeDamage(int damage)
    {
        currentHP -= damage;
        PlayerPrefs.SetInt("currentHP", currentHP);

        if (currentHP <= 0)
        {
            return true;
        }
        else
            return false;

    }

    public void Heal()
    {

        if ((currentHP + heal) >= maxHP)
        {
            currentHP = maxHP;
        }
        else
        {
            currentHP += heal;
        }
        
        PlayerPrefs.SetInt("currentHP", currentHP);

    }
}
