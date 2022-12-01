using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour

{
    public CharacterController characterController;
    public float speed = 6;

    private void Start()
    {
        characterController = this.gameObject.GetComponent<CharacterController>();
    }
    void Update()

    {
        Move();
    }

    private void Move()
    {

        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove;
        characterController.Move(speed * Time.deltaTime * move);
    }

    //gravité 

    private float gravity = 9.87f;
    private float verticalSpeed = 0;

    private void OnAnimatorMove()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        if (characterController.isGrounded) verticalSpeed = 0;
        else verticalSpeed -= gravity * Time.deltaTime; 

        Vector3 gravityMove = new Vector3 (0, verticalSpeed, 0);
        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove; 
        characterController.Move(speed * Time.deltaTime * move + gravityMove * Time.deltaTime);
    }
    //systeme de camera et rotation avec la souris 
    public Transform cameraHolder; 
    public float mouseSensitivity = 2f;
    public float upLimit = -50; 
    public float downLimit = 50;

    private void FixedUpdate()
    {
        Move();
        Rotate(); 

    }
    
    public void Rotate ()
    {
        float horizontalROtation = Input.GetAxis("Mouse X");
        float verticalRotation = Input.GetAxis("Mouse Y");

        transform.Rotate(0, horizontalROtation * mouseSensitivity, 0);
        cameraHolder.Rotate(-verticalRotation*mouseSensitivity,0,0);

        Vector3 currentRotation = cameraHolder.localEulerAngles;
        if (currentRotation.x > 180) currentRotation.x -= 360;
        currentRotation.x = Mathf.Clamp(currentRotation.x, upLimit, downLimit);
        cameraHolder.localRotation = Quaternion.Euler(currentRotation);



    }

}
