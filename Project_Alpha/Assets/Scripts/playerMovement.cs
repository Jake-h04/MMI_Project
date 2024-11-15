using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementX : MonoBehaviour
{
    private Rigidbody playerRb;
    public float playerSpeed = 50.0f;

    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        // Moves Player forward
        transform.Translate(playerSpeed * Time.deltaTime * Vector3.forward * forwardInput);

        // Moves Player on the horizontal axis(Left / Right)
        transform.Translate(playerSpeed * Time.deltaTime * Vector3.left * horizontalInput);        
    }
}
