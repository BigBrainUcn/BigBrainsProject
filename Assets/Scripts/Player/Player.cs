using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int FuerzaDeSalto;
    public int VelocidadDeMov;
    private Rigidbody2D rb;
    private bool isJumping = true;
    private Animator animator;

    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
         this.rb.AddForce(new Vector3(0, FuerzaDeSalto, 0), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Border"))
        {
            this.isJumping = true;
            animator.SetBool("isJump", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Border"))
        {
            this.isJumping = false;
            animator.SetBool("isJump", false);

        }
    }
}
