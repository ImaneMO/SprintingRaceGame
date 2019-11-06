using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public Rigidbody2D rb2;
    public Animator animator;

   
    public float maxRun;
    public float jump;
    private bool isGrounded = false;
    private bool facingRight;

    // Start is called before the first frame update
    void Start()
    {
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Deplacement du joueur
        Vector3 mouvement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += mouvement * Time.deltaTime * maxRun;

        //le saut 
        if (Input.GetKeyDown("space") && isGrounded) 
        {
            rb2.velocity += new Vector2(0, jump);
        }

        //facing
        Flip(Input.GetAxis("Horizontal"));

        //animation courire
        animator.SetFloat("vitesse", Mathf.Abs(Input.GetAxis("Horizontal")));


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            rb2.transform.parent = null;
        }
    }

    //function
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
           
    }

    private void Flip(float flip)
    {
        if (flip > 0 && !facingRight || flip < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;

        }
    }
}
