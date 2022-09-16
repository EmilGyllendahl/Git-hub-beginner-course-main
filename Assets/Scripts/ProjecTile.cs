using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecTile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    [SerializeField] private GameObject damageIndicatorPrefab; // indicates the health field
    private bool isActive;

    public void Initialize()
    {
        isActive = true; // if it is true that isactive is true
                         
        // -------- This method is for projectiles that have a parabole. ----------
        // We add a force only once, not every frame
        // Make sure to have "useGravity" toggled on in the rigid body
        projectileBody.AddForce(transform.forward * 700f + transform.up * 300f); 
    }

    void Update()
    {
        if (isActive)
        {

            // -------- This method is for projectiles that go in a straight line. ----------
            // We change the position every frame
            // Make sure to have "useGravity" toggled off in the rigid body, otherwise it will fall as it flies (unless thats what you want)

            // Use either the following line (movement with the rigid body)
            //projectileBody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);

            // or this one (movement with the transform), both are ok
            //transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision) // if a collision happens between two colliders/rigidbodys
    {
        GameObject damageIndicator = Instantiate(damageIndicatorPrefab); // Start/activate the damage indicator on the game object.
        damageIndicator.transform.position = collision.GetContact(0).point; // where the contact of the collision is made, make damageindikator visible

    }
}
