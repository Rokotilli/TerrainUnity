using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{   
    [SerializeField] private float speed = 5f;
    [SerializeField] private float gravity = 15f;
    [SerializeField] private float jump = 5f;
    [SerializeField] private Vector3 moveDirection = Vector3.zero;

    void Update()
    {
        CharacterController characterController = GetComponent<CharacterController>();

        if (characterController.isGrounded){
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump")){
                moveDirection.y = jump;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
