#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveScene()
    {
        Time.timeScale = 1f;
    }
    public void CloseScene()
    {
        Time.timeScale = 0f;
    }
    public void load_Scene(string S)
    {
        SceneManager.LoadScene(S);
    }
    public void Reset_Game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
#endif