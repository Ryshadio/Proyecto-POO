using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 60;
    [SerializeField] private float jumpForce = 100;
    Rigidbody2D rigidBody;
    public Collider2D col;
    SpriteRenderer spriteRenderer;
    Animator animator;
    Transform transf;
    public bool inBattle;


    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        col = gameObject.GetComponent<Collider2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        animator = gameObject.GetComponent<Animator>();
        transf = gameObject.GetComponent<Transform>();
        PlayerPrefs.SetInt("currentHP", 50);

    }
    
    // Update is called once per frame
    void Update()
    {
        move();
        jump();
        CheckGround();
    }

    

    private void move()
    {
        var getDirection = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(getDirection*moveSpeed, rigidBody.velocity.y);
        if (getDirection < 0) { spriteRenderer.flipX = true; }
        if (getDirection > 0) { spriteRenderer.flipX = false; }
        animator.SetBool("moving", true);
        if(getDirection == 0)
        {
            animator.SetBool("moving", false);
        }
    }

    private void jump()
    {
        animator.SetFloat("jumpVelocity",rigidBody.velocity.y );
        if (!col.IsTouchingLayers(LayerMask.GetMask("ground")))
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector2.up*jumpForce);
        }
    }

    private void CheckGround()
    {
        if (col.IsTouchingLayers(LayerMask.GetMask("ground")))
        {
            animator.SetBool("isGrounded", true);
        }
        else
        {
            animator.SetBool("isGrounded", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemy") && inBattle == false)
        {
            
            Destroy(collision.collider.gameObject);
            inBattle = true;
            SceneManager.LoadScene("Battle", LoadSceneMode.Additive); 
        }else if (collision.collider.gameObject.CompareTag("nave"))
        {
            SceneManager.LoadScene("Gano");
        }
    }




}
