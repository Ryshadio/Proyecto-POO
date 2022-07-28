using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

   

    public string unitName;
    public int damage;
    public int maxHP;
    public int currentHP;

    virtual public bool TakeDamage(int damage)
    {
        currentHP -= damage;


        if (currentHP <= 0)
        {
            return true;
        }
        else
            return false;
    }

}
