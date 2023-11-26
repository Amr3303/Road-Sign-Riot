using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            print(contact.thisCollider.name + " hit " + contact.otherCollider.name);
            // Visualize the contact point
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
    }


    private void OnCollisionEnter(Collider Collision)
    {
        if(Collision)
        {

        }
        Debug.Log("Do something here");
        float speed = GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
        if (Collision.gameObject.name == "Player")
        {

            Debug.Log("Do something here");
            if (speed > 60f)
            {
                Time.timeScale = 0f;
                gameOverCanvas.SetActive(true);
                Debug.Log("Do something here Speed >60");
            }
        }
    }

    
}
