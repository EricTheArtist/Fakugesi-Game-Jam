using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BatteryBarController : MonoBehaviour
{
    [Header("UI Images")]
    public Image battery_bar;

    [Header("Control Stats")]
    public float fill_amount;
    public float reduce_amount;
    public float flicker_timer;

    // Start is called before the first frame update
    void Start()
    {
        battery_bar.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        bar_decrease(reduce_amount);
        bar_control();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Battery")
        {
            bar_increase(fill_amount);
            other.gameObject.SetActive(false);
        }
    }
    public void bar_increase(float num)
    {
        battery_bar.fillAmount += num;
    }
    public void bar_decrease(float num)
    {
        battery_bar.fillAmount -= (num)/100;
    }

    public void bar_control()
    {
        //flicker rate
        //change colour
        colour_control();
        //reload scene
        respawn();
    }
    public void colour_control()
    {
        if (battery_bar.fillAmount >= 0.7)
        {
            battery_bar.color = Color.green;
        }
        else if (battery_bar.fillAmount < 0.7 & battery_bar.fillAmount>0.3)
        {
            battery_bar.color = Color.yellow;
        }
        else if (battery_bar.fillAmount < 0.3)
        {
            battery_bar.color = Color.red;
        }
    }
    public void flicker_control()
    {
        if (battery_bar.fillAmount >= 0.7)
        {
            Debug.Log("do a flicker");
            StartCoroutine(battery_dying());
        }
        else if (battery_bar.fillAmount < 0.7)
        {
            StartCoroutine(battery_dying());
            Debug.Log("do a flicker");
        }
        else if (battery_bar.fillAmount < 0.3)
        {
            StartCoroutine(battery_dying());
            Debug.Log("do a flicker");
        }
        
    }
    public void respawn()
    {
        if (battery_bar.fillAmount <= 0)
        {
            StartCoroutine(battery_dead());
        }
    }
    IEnumerator battery_dying()
    {
        //start flicker
        if (Input.GetMouseButtonDown(0))
        {
            //stop flicker 
            yield return null;
        }
    }
    IEnumerator battery_dead()
    {
        Debug.Log("Player Flicker");
        yield return new WaitForSeconds(flicker_timer);
        //turn off light
        Debug.Log("Display Game Over");
        yield return new WaitForSeconds(5f);
        Debug.Log("Restarting Game");
        SceneManager.LoadScene(1);
    }
   
}
