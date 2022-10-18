using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationInteraction : MonoBehaviour
{
    public GameObject interact_ui;
    public GameObject turbine, turbine_props;
    public bool can_interact;

    Animator turbine_aime;
    MovingPlatforms moving_platforms;
    // Start is called before the first frame update
    void Start()
    {
        turbine_props = this.transform.parent.gameObject;
        turbine = turbine_props.transform.parent.gameObject;
        turbine_aime = turbine_props.GetComponent<Animator>();
        moving_platforms = turbine.GetComponent<MovingPlatforms>();
        turbine_aime.SetBool("Active", false);
    }

    // Update is called once per frame
    void Update()
    {
        interactor();
    }
    void interactor()
    {
        if (can_interact)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                interact_ui.SetActive(false);
                //play animation;
                moving_platforms.can_move = true;
                turbine_aime.SetBool("Active", true);
                this.gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            can_interact = true;
            interact_ui.SetActive(true);
            Debug.Log("Player reached");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            can_interact = false;
            interact_ui.SetActive(false);
            Debug.Log("Player reached");
        }
    }
}
