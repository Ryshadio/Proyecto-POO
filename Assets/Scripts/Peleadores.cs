using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peleadores : MonoBehaviour
{
    public static Peleadores inst;
    private void Awake()
    {
        if (Peleadores.inst == null)
        {
            Peleadores.inst = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public GameObject player;
    public GameObject enemy;




}
