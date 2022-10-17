using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaxiCollide : MonoBehaviour
{
    public Transform playerTrans;
    public Transform startPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Taxi")
        {
            //change to schen 1
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
