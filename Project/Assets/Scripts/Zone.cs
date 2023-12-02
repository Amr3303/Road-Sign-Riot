using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public Rigidbody Player;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider collision)
    {
        float speed = Player.velocity.magnitude * 3.6f;
        
        if (speed > 60)
        {
            Time.timeScale = 0f;
            gameOverCanvas.SetActive(true);
            Debug.Log("Do something here Speed >60");
        }

    }
}
   

