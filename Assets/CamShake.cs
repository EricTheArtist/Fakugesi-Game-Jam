using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamShake : MonoBehaviour
{
    public static CamShake Instance { get; private set; }

    private CinemachineVirtualCamera cam;
    private float shakeTimer;

    private void Awake()
    {
        Instance = this;
       cam = GetComponent<CinemachineVirtualCamera>();
    }

    private void Update()
    {
        if (shakeTimer > 0)
        {
            //countdown shake timer
            shakeTimer -= Time.deltaTime;

            //stop shake
            if (shakeTimer <= 0f)
            {
                CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = cam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

                cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0f;
            }
        }
    }

    public void Shake(float intensity, float time)
    {
        //get cinemachine noise properties
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = cam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        //changing amplitude
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;
        shakeTimer = time;
    }
}
