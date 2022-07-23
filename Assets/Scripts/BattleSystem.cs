using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState
{
    START,
    PLAYERTURN,
    ENEMYTURN,
    WON,
    LOST
}
public class BattleSystem : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    public Transform enemyBattleStation;

    public BattleState state;
    
    void Start()
    {
        state = BattleState.START;
        
        SetupBattle();
    }


    void SetupBattle()
    {
        Instantiate(enemyPrefab, enemyBattleStation);
    }



}
