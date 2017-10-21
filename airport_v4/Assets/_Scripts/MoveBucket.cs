using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveBucket : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //      transform.position = new Vector3(0, transform.position.y, 0);
    }
    void Update()
    {

        // transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}