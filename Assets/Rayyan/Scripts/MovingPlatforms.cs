using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public bool can_move;
    public Vector3 pos1, pos2;
    public float speed = 0.02f;

    
    /* public float degrees_per_sec = 0f;
     public float amplitude_y = 1f;
     public float frequency_y = 1f;
     public float amplitude_x = 1f;
     public float frequency_x = 1f;
     Vector3 posOffset = new Vector3();
     Vector3 tempPos = new Vector3();
     */
    void Start()
    {
        can_move = false;
        pos1 = gameObject.transform.position;
        //posOffset = transform.position;
    }

    void Update()
    {
        if (can_move)
        {
            transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1f));
           // transform.position = Vector3.Lerp(up, down, Mathf.PingPong(Time.time * speed, 1f));
        }
        
    }
}
/*transform.Rotate(new Vector3(0f, Time.deltaTime * degrees_per_sec, 0f), Space.World);

            tempPos = posOffset;
            tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency_y) * amplitude_y;
            tempPos.x += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency_x) * amplitude_x;

            transform.position = tempPos;
*/