using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Controller : MonoBehaviour
{
    public Animator SpriteAnimator;
    public SpriteRenderer SRender;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpriteAnimator.SetBool("Jump", true);
           
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SpriteAnimator.SetBool("Jump", false);

        }



        if (Input.GetKeyDown(KeyCode.W))
        {
            SpriteAnimator.SetBool("Away", true);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            SpriteAnimator.SetBool("Away", false);
        }



        if (Input.GetKeyDown(KeyCode.D))
        {
            SpriteAnimator.SetBool("Walk", true);

            SRender.flipX = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            SpriteAnimator.SetBool("Walk", false);
        }




        if (Input.GetKeyDown(KeyCode.A))
        {
            SpriteAnimator.SetBool("Walk", true);

            SRender.flipX = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            SpriteAnimator.SetBool("Walk", false);
        }



        if (Input.GetKeyDown(KeyCode.S))
        {
            SpriteAnimator.SetBool("Towards",true);
            
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            SpriteAnimator.SetBool("Towards", false);

        }








    }
}
