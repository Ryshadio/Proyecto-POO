using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Detector detector;
    private int rutina;
    public float cronometro;
    private Animator animator;
    private int direccion;
    



    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        
        Comportamiento();
        
    }

  
    public void Comportamiento()
    {
        

        animator.SetBool("move", false);
        cronometro += 1 * Time.deltaTime;
        
        if (cronometro >= 1)
        {
            rutina = Random.Range(0, 2);
            cronometro = 0;
        }

        switch (rutina)
        {
            case 0:

                animator.SetBool("move", false);
                break;

            case 1:

                direccion = Random.Range(0, 2);
                rutina++;
                break;

            case 2:

                switch (direccion)
                {
                    case 0:
                        transform.rotation = Quaternion.Euler(0, 0, 0);
                        if (detector.Check())
                        {
                        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                        animator.SetBool("move", true);
                        }
                        break;

                    case 1:
                        transform.rotation = Quaternion.Euler(0, 180, 0);
                        if (detector.Check())
                        {
                            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                            animator.SetBool("move", true);
                        }
                        break;
                }
                
                break;
        }
    }
}
