using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_LoadGame : MonoBehaviour
{
    public bool QuitGame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(QuitGame == false)
        {
            SceneManager.LoadScene(1);
        }
        if(QuitGame == true)
        {
            Application.Quit();
        }
        
    }
}
