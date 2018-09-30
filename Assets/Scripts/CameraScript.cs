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
	}
}
