using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void SwitchScene(string S)
    {
        SceneManager.LoadScene(S);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void StopGame()
    {
        Time.timeScale = 0f;
    }

}

