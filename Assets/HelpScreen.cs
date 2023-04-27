using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScreen : MonoBehaviour
{
    public GameObject Help_screen;
    bool H_toggle = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if(H_toggle == false)
            {
                Help_screen.SetActive(true);
                H_toggle = true;
            }
            else
            {
                Help_screen.SetActive(false);
                H_toggle = false;
            }
        }
    }
}
