using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiSpline : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private Transform pointC;
    [SerializeField] private Transform ABdistance;
    [SerializeField] private Transform BCdistance;


    private float interpolateAmount; // if t = 0: lerp to point A, & if t = 0: lerp to point b


    // Update is called once per frame
    void Update()
    {
        //constantly icreasing interpolationAmount using time.delta time & loops back to 0 coz adding modular of 1
        interpolateAmount = (interpolateAmount + Time.deltaTime) % 1f;
       
        ABdistance.position = Vector3.Lerp(pointA.position, pointB.position, interpolateAmount);
        BCdistance.position = Vector3.Lerp(pointB.position, pointC.position, interpolateAmount);
    }
}
