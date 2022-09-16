using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private float speed = 2f; // How fast the object moves
  

    void Update()
    {
        if (playerTurn.IsPlayerTurn()) // When the turn manager gets the instance and checks which player it is with the playerindex.


        {
            if (Input.GetAxis("Horizontal") != 0) // If the input is or is not equal to horizontal

            {
                // transform the position to the right/left and get the speed value with times in second with meters
                transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal")); 
                
            }

            if (Input.GetAxis("Vertical") != 0) // If the input is or is not equal to Vertical
            {
                // transform the position forward/backwards and get the speed value with times in second with meters
                transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));
            }

            if (Input.GetKeyDown(KeyCode.Space) && IsTouchingFloor()) // If the space button is pressed, jump
            {
                Jump();
            }
        }
        
    }


    private void Jump()
    {
        // characterBody.velocity = Vector3.up * 10f;
        characterBody.AddForce(Vector3.up * 500f);
    }

    private bool IsTouchingFloor()
    {
        RaycastHit hit;
        // Parameters:
        // - The center from where we shoot 1
        // - Radius of the sphere 2 
        // - Direction of the sphere 3
        // -  Hit parameter
        // - Distance the sphere
       bool result = Physics.SphereCast(transform.position, 0.15f, -transform.up, out hit, 1f);

     
            return result;
    }
   
}
 