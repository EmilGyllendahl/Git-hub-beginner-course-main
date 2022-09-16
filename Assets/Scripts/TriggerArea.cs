using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour

   
{

    private void OnTriggerEnter (Collider other) // OnTriggerEnter kallas in och börjar gälla när olika colliders mötes upp med varandra Collider other =  En collider mot en annan collider som inte är samma.
    {
        GameObject otherObject = other.gameObject; // När spelobjektet collidar med ett annat.
        otherObject.GetComponent<MeshRenderer>().material.color = GetRandomColor(); // Då kommer det andra objektets komponent meshrenderer som i sin tur hämtar materialet och färgen på det som sen slumpas.
    }


    private void OnTriggerStay(Collider other)
    {
        // Kommer hända varje frame som vi är inuti collidern så uppdateras den med de två olika colliderserna, så länge de är inuti varandra.
    }
    

    private Color GetRandomColor ()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)); // Funktionen för att slumpa olika färger

        return color; // Återvänder med den nya färgen som slumpartats fram.
    }
}
