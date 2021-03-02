using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    GameObject cam;
    Rigidbody rb;
    void Start()
    {
        cam = this.gameObject;
        rb = cam.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W)) rb.AddForce(Vector3.forward * 2, ForceMode.Impulse);
        else if (Input.GetKey(KeyCode.S)) rb.AddForce(Vector3.forward * -2, ForceMode.Impulse);
        else if (Input.GetKey(KeyCode.A)) rb.AddForce(Vector3.up * 2, ForceMode.Impulse);
        else if (Input.GetKey(KeyCode.D)) rb.AddForce(Vector3.down * 2, ForceMode.Impulse);
        else rb.velocity = new Vector3(0, 0, 0);
    }
}
