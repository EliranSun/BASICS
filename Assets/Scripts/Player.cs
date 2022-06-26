using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private float update;

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Start1");
    }

    // Update is called once per frame
    void Update() {
        update += Time.deltaTime;
        if (update > 1.0f) {
            update = 0.0f;
            Debug.Log("Update");
        }
    }
}
