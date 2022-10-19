using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_LoadGame : MonoBehaviour
{
    public bool QuitGame = false;
    public bool EndGame = false;
    public bool PlayGame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitMyGame();
        }
    }

    public void QuitMyGame()
    {
        Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(EndGame == true)
        {
            SceneManager.LoadScene(2);
        }
        if(PlayGame == true)
        {
            SceneManager.LoadScene(1);
        }
        if(QuitGame == true)
        {
            Application.Quit();
        }
        
    }
}
