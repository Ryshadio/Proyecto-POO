using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public enum BattleState
{
    START,
    PLAYERTURN,
    ENEMYTURN,
    WON,
    LOST,
    STAND
}
public class BattleSystem : MonoBehaviour
{
    public static BattleSystem inst;
    private string prefHPName = "currentHP";
    public GameObject player;
    public GameObject enemyPrefab;
    public Transform enemyBattleStation;
    BattleEnemy enemyUnit;
    BattlePlayer playerUnit;
    public BattleState state;
    public TextMeshProUGUI dialogueText;
    public EnemyBattleHUD enemyBattleHUD;
    public PlayerBattleHUD playerBattleHUD;



   
    
    
    void Start()
    {
        state = BattleState.START;
        PlayerPrefs.SetInt(prefHPName, 50);
        StartCoroutine(SetupBattle());
    }


    IEnumerator SetupBattle()
    {

        GameObject enemy = Instantiate(enemyPrefab, enemyBattleStation);
        enemyUnit = enemy.GetComponent<BattleEnemy>();

        playerUnit = player.GetComponent<BattlePlayer>();

        dialogueText.text = "Un " + enemyUnit.unitName + " bloquea tu camino...";

        playerBattleHUD.SetHUD(playerUnit);
        enemyBattleHUD.SetHUD(enemyUnit);

        playerUnit.currentHP = PlayerPrefs.GetInt("currentHP");

        yield return new WaitForSeconds(2f);

        state = BattleState.PLAYERTURN;
        PlayerTurn();


    }

    IEnumerator PlayerAttack()
    {
        state = BattleState.STAND;
        bool isDead = enemyUnit.TakeDamage(playerUnit.damage);

        enemyBattleHUD.SetHP(enemyUnit.currentHP);
        dialogueText.text = "Bread ha golpeado a " + enemyUnit.unitName;

        yield return new WaitForSeconds(2f);
        
        if (isDead)
        {
            state = BattleState.WON;
            StartCoroutine(EndBattle());
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }  
    }

    IEnumerator PlayerHeal()
    {
        playerUnit.Heal();

        playerBattleHUD.SetHP(playerUnit.currentHP);
        dialogueText.text = "Bread se ha curado";

        yield return new WaitForSeconds(2f);

        state = BattleState.ENEMYTURN;
        StartCoroutine(EnemyTurn());
      
    }

    IEnumerator EndBattle()
    {
        if(state == BattleState.WON)
        {
            dialogueText.text = "Has ganado el combate...";
            SceneManager.UnloadSceneAsync("Battle");
        } else if(state == BattleState.LOST)
        {
            dialogueText.text = "Has muerto...";
            SceneManager.UnloadSceneAsync("Battle");
            SceneManager.LoadScene("Creditos");
        }

        yield return new WaitForSeconds(2f);
        
    }

    IEnumerator EnemyTurn()
    {
        dialogueText.text = enemyUnit.unitName + " te ataca!";

        yield return new WaitForSeconds(1f);

        bool isDead = playerUnit.TakeDamage(enemyUnit.damage);

        playerBattleHUD.SetHP(playerUnit.currentHP);

        yield return new WaitForSeconds(1f);

        if (isDead)
        {
            state = BattleState.LOST;
            StartCoroutine(EndBattle());
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
    }   







    void PlayerTurn()
    {
        dialogueText.text = "Elige una accion";
    }

    public void OnAttackButton()
    {
        if(state == BattleState.PLAYERTURN)
        {
            StartCoroutine(PlayerAttack());
        }
        return;
    }

    public void OnHealButton()
    {
        if (state == BattleState.PLAYERTURN)
        {
            StartCoroutine(PlayerHeal());
        }
        
        return;
    }

}
