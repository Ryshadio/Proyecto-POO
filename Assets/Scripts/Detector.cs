using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{

    [SerializeField] private Transform detector;
    [SerializeField] private float distancia;

    public bool Check()
    {
        RaycastHit2D info = Physics2D.Raycast(detector.position, Vector2.down, distancia);
        return info;
    }
    
}
