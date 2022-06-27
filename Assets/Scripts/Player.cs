using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Transform groundCheckTransform;
    private bool isJumpKeyPressed;
    private float horizontalInput;
    private Rigidbody rigidPlayer;
    private LayerMask playerMask;

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Start!");
        rigidPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            isJumpKeyPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }

    // once per engine, 100 per seconds in the current unity engine
    private void FixedUpdate() {
        rigidPlayer.velocity = new Vector3(horizontalInput * 8, rigidPlayer.velocity.y, 0);

        // Including thyself
        if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f, playerMask).Length == 0) {
            return;
        }


        if (isJumpKeyPressed)
        {
            rigidPlayer.AddForce(Vector3.up * 30, ForceMode.Impulse);
            isJumpKeyPressed = false;
        }
    }
}
