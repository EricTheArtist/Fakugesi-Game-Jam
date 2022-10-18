using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaxiCollide : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Taxi")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            StartCoroutine("Hit");
        }
    }
    IEnumerator Hit()
    {
        //Debug.Log("Screenshake");
        yield return new WaitForSeconds(0.1f);
        //turn off light
        //Debug.Log("Display Game Over");
        //yield return new WaitForSeconds(5f);
        //Debug.Log("Restarting Game");
        SceneManager.LoadScene(1);
    }
}
