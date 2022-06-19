using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float playerVelocity;
    public float jumpForce;
    private bool isJumping;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Rigidbody2D playerRigidBody;

    private void OnEnable()
    {
        this.animator = GetComponent<Animator>();
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        this.playerRigidBody = GetComponent<Rigidbody2D>();
    }

    private void AttributesInitialization()
    {
        this.playerVelocity = 0.1f;
        this.jumpForce = 9f;
        this.isJumping = true;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AttributesInitialization();
    }

    private void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    
        this.WalkAnimations();
        this.PlayerJump();
    }

    void PlayerMovements()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(playerVelocity, 0f, 0f);
            spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-playerVelocity, 0f, 0f);
            spriteRenderer.flipX = true;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerVelocity);
        this.PlayerMovements();
    }
  
    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            playerRigidBody.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode2D.Impulse);
        }
    }

    void WalkAnimations()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A) && !isJumping)
        {
            animator.SetBool("isWalk", true);
        }
        if (!Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && !isJumping)
        {
            animator.SetBool("isWalk", false);

        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            this.isJumping = true;
            animator.SetBool("isJump", true);
            animator.SetBool("isWalk", false);
        }

        if (other.gameObject.CompareTag("Wc"))
        {
            this.isJumping = true;
            animator.SetBool("isJump", true);
            animator.SetBool("isWalk", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            this.isJumping = false;
            animator.SetBool("isJump", false);
        }

        if (other.gameObject.CompareTag("Wc"))
        {
            this.isJumping = false;
            animator.SetBool("isJump", false);
        }
    }
}