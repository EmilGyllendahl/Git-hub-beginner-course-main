using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{

    // Mesh render �r det som p�verkar objektens utsende som f�rg etc.
    [SerializeField] private MeshRenderer meshRenderer; // namnet vi ger till objektet


    private void OnCollisionEnter(Collision collision) // N�r objektet/rigidbodyn r�r ett annat objekt
    {
        meshRenderer.material.color = GetRandomColor(); // meshrenderern genererar en slumpm�ssigt vald f�rg n�r den k�nner av en collision mellan tv� olika object
    }

    private void OnCollisionExit(Collision collision)
    {
        meshRenderer.material.color = GetRandomColor();
    }

    private Color GetRandomColor()
    {


        // skapar ny f�rg med slumpm�ssiga v�rden Range �r f�r float v�rden
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        return color;
    }


}
