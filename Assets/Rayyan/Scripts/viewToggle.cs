using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewToggle : MonoBehaviour
{
    public bool front, side;

    private void Start()
    {
        front = true;
    }
    void Update()
    {
        if (Input.GetMouseButtonUp(0) & side)
        {
            transform.rotation = Quaternion.Euler(30, 0, 0);
            front = true;
            side = false;
        }
        else if(Input.GetMouseButtonUp(0) & front)
        {
            transform.rotation = Quaternion.Euler(30, 90, 0);
            side = true;
            front = false;
        }
    }
}
