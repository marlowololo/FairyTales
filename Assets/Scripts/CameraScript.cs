using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    public GameObject Player;

    private Vector3 CameraInitialPosition;

    void Start() {
        CameraInitialPosition = transform.position;
    }

	void Update () {
        transform.position = Player.transform.position + CameraInitialPosition;
        transform.rotation = Quaternion.Euler(
            transform.rotation.eulerAngles.x - Input.GetAxis("Mouse Y"),
            transform.rotation.eulerAngles.y + Input.GetAxis("Mouse X"),
            0
        );
    }
}
