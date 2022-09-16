using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    private static PickupManager instance;
    [SerializeField] GameObject pickupPrefab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static PickupManager GetInstance()
    {
        return instance;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newPickup = Instantiate(pickupPrefab);
            newPickup.transform.position = new Vector3(Random.Range(1f, -2f), 0.37f);
        }
    }
}
