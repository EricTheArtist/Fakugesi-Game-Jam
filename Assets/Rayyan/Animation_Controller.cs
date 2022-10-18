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
        if (Input.anyKey)
        {
            SpriteAnimator.SetBool("Stand", false);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpriteAnimator.SetBool("Jump", true);
            SpriteAnimator.SetBool("Stand", false);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SpriteAnimator.SetBool("Jump", false);
            SpriteAnimator.SetBool("Stand", true);

        }



        if (Input.GetKeyDown(KeyCode.W))
        {
            SpriteAnimator.SetBool("Away", true);
            SpriteAnimator.SetBool("Stand", false);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            SpriteAnimator.SetBool("Away", false);
            SpriteAnimator.SetBool("Stand", true);
        }



        if (Input.GetKeyDown(KeyCode.D))
        {
            SpriteAnimator.SetBool("Walk", true);
            SpriteAnimator.SetBool("Stand", false);

            SRender.flipX = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            SpriteAnimator.SetBool("Walk", false);
            SpriteAnimator.SetBool("Stand", true);
        }




        if (Input.GetKeyDown(KeyCode.A))
        {
            SpriteAnimator.SetBool("Walk", true);
            SpriteAnimator.SetBool("Stand", false);

            SRender.flipX = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            SpriteAnimator.SetBool("Walk", false);
            SpriteAnimator.SetBool("Stand", true);
        }



        if (Input.GetKeyDown(KeyCode.S))
        {
            SpriteAnimator.SetBool("Towards",true);
            SpriteAnimator.SetBool("Stand", false);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            SpriteAnimator.SetBool("Towards", false);
            SpriteAnimator.SetBool("Stand", true);

        }








    }
}
