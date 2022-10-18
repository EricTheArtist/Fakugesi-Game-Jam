using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaxiSpline : MonoBehaviour
{
    [Header("Points")]
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private Transform pointC;
    [SerializeField] private Transform pointD;
    //[SerializeField] private Transform pointE;

    [Header("Taxis")]
    [SerializeField] private Transform abTaxi;
    [SerializeField] private Transform bcTaxi;
    [SerializeField] private Transform cdTaxi;
    [SerializeField] private Transform daTaxi;
    [SerializeField] private Transform deTaxi;



    private float interpolateAmount; // if t = 0: lerp to point A, & if t = 0: lerp to point b


    // Update is called once per frame
    void Update()
    {
        //constantly icreasing interpolationAmount using time.delta time & loops back to 0 coz adding modular of 1
        interpolateAmount = (interpolateAmount + Time.deltaTime) % 1f;

        abTaxi.position = Vector3.Lerp(pointA.position, pointB.position, interpolateAmount);

        bcTaxi.position = Vector3.Lerp(pointB.position, pointC.position, interpolateAmount);

        cdTaxi.position = Vector3.Lerp(pointC.position, pointD.position, interpolateAmount);

        daTaxi.position = Vector3.Lerp(pointD.position, pointA.position, interpolateAmount);

        //deTaxi.position = Vector3.Lerp(pointD.position, pointE.position, interpolateAmount);

    }
}
