using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    public Rigidbody head;          //RB applies physics(force) Gameobject cannot
    private CharacterController characterController;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();  //refering to the char collider on space marine 
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterController.SimpleMove(moveDirection * moveSpeed);          //track movement&direction with vec3
                                            //SimpleMove helps character move in their direction but not thorugh obstacles.

        //Vector3 pos = transform.position; // getting position of space marine
        //pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;  //horizontal speed value
        //pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        //transform.position = pos;
    }

    private void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"),
                                0, Input.GetAxis("Vertical"));

        if (moveDirection == Vector3.zero)  
        {
              /*if the value is at zero (not moving) the head will stand still*/
        }
        else
        {
            head.AddForce(transform.right * 150, ForceMode.Acceleration);   //Force is added to head in congruence with the moving character
        }
    }
}
