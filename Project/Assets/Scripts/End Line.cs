using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class End_Line : MonoBehaviour
{
    public GameObject EndLine;
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
            Time.timeScale = 0f;
            EndLine.SetActive(true);
    }

}
