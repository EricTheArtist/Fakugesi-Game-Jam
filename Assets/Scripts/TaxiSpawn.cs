using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiSpawn : MonoBehaviour
{

    public GameObject taxiPrefab;
    public GameObject player;
    public Transform playerPos;

   // public ThirdPersonController thirdPersonController; 

    // Start is called before the first frame update
    void Start()
    {
        //player.gameObject.GetComponent<UnitySc>
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(taxiPrefab, playerPos.position, Quaternion.identity);
        }
    }
}
