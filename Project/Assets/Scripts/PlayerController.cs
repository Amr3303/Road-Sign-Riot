using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    private float speed = 25.0f;
    private float turnSpeed= 25.0f;
    private float horizontalInput;
    private float forwardInput;
    public float JumpInput;
    public Material[] carMaterials;
    public Renderer carRenderer;

    // Start is called before the first frame update
    void Start()
    {
        carRenderer.material = carMaterials[0];
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        JumpInput = Input.GetAxis("Jump");
        //we'll move the vehicle forward
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //we'll move the vehicle forward
        transform.Translate(Vector3.up * Time.deltaTime * speed * JumpInput);
        // We turn the vehicle
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed* horizontalInput);
        transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * horizontalInput);

        // Change the color of the car when the user presses a key
        if (Input.GetKeyDown(KeyCode.C))
        {
            // Generate a random index to select a new color
            int randomIndex = Random.Range(0, carMaterials.Length);

            // Set the new color of the car
            carRenderer.material = carMaterials[randomIndex];
        }
    }
}
