using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input (WASD keys)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Create a vector from the input, and normalize it to prevent faster diagonal movement
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // Move the character based on speed and time to ensure smooth movement
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
