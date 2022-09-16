using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{

    // Mesh render är det som påverkar objektens utsende som färg etc.
    [SerializeField] private MeshRenderer meshRenderer; // namnet vi ger till objektet


    private void OnCollisionEnter(Collision collision) // När objektet/rigidbodyn rör ett annat objekt
    {
        meshRenderer.material.color = GetRandomColor(); // meshrenderern genererar en slumpmässigt vald färg när den känner av en collision mellan två olika object
    }

    private void OnCollisionExit(Collision collision)
    {
        meshRenderer.material.color = GetRandomColor();
    }

    private Color GetRandomColor()
    {


        // skapar ny färg med slumpmässiga värden Range är för float värden
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        return color;
    }


}
