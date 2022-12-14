using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour

{

    public static PlayerController instance;

    public int currentHealth;
    public int maxHealth = 3;  


    private Animator animator;


    public CharacterController characterController;
    public float speed = 6;

    
    private void Awake()
    {
        instance = this; 

    }
    
    
    
    private void Start()
    {
        currentHealth = maxHealth;

        animator = GetComponent<Animator>();


        characterController = this.gameObject.GetComponent<CharacterController>();
    }
    void Update()

    {
        Move();
        
        
    }


    //gravité 

    private float gravity = 9.87f;
    private float verticalSpeed = 0;

    private void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        if (characterController.isGrounded) verticalSpeed = 0;
        else verticalSpeed -= gravity * Time.deltaTime; 

        Vector3 gravityMove = new Vector3 (0, verticalSpeed, 0);
        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove; 
        characterController.Move(speed * Time.deltaTime * move + gravityMove * Time.deltaTime);

        animator.SetBool("IsWalking", verticalMove != 0 || horizontalMove != 0);
    }

    private void FixedUpdate()
    {
        Move();
        Rotate(); 
    }
    
    public void Rotate ()
    {
        float horizontalROtation = Input.GetAxis("Mouse X");

        transform.Rotate(0, horizontalROtation, 0);
    }

    public void TakeDamage(int damage)
    {

        if(currentHealth >= 0 )
        {
          currentHealth -= damage;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    }

    

   
     
        
}
