using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    public GameObject cameraPivot;

    private Rigidbody rb;
    private bool moving;
    private Vector3 rotationVector;
    private float horizontalInput, verticalInput;

    // Use this for initialization
    void Awake() {
        rb = GetComponent<Rigidbody>();
        moving = false;
        rotationVector = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical")) {
            rotationVector.Set(
                horizontalInput,
                0, 
                verticalInput);
            transform.rotation = Quaternion.LookRotation(rotationVector) * Quaternion.Euler(0, cameraPivot.transform.rotation.eulerAngles.y, 0);
            moving = true;
        }

        if(Input.GetButtonUp("Horizontal") || Input.GetButtonUp("Vertical")) {
            moving = false;
        }
    }

    void FixedUpdate() {
        if(moving) {
            rb.velocity = transform.forward * movementSpeed;
        }
    }
}
