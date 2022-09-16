using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour

   
{

    private void OnTriggerEnter (Collider other) // OnTriggerEnter kallas in och b�rjar g�lla n�r olika colliders m�tes upp med varandra Collider other =  En collider mot en annan collider som inte �r samma.
    {
        GameObject otherObject = other.gameObject; // N�r spelobjektet collidar med ett annat.
        otherObject.GetComponent<MeshRenderer>().material.color = GetRandomColor(); // D� kommer det andra objektets komponent meshrenderer som i sin tur h�mtar materialet och f�rgen p� det som sen slumpas.
    }


    private void OnTriggerStay(Collider other)
    {
        // Kommer h�nda varje frame som vi �r inuti collidern s� uppdateras den med de tv� olika colliderserna, s� l�nge de �r inuti varandra.
    }
    

    private Color GetRandomColor ()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)); // Funktionen f�r att slumpa olika f�rger

        return color; // �terv�nder med den nya f�rgen som slumpartats fram.
    }
}
