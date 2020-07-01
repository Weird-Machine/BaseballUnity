using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingDog : MonoBehaviour
{
    public float fallspeed = 0.2f;
    public Vector3 position;
    public Rigidbody rb;
    public float thrust=0.1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

       
    }
    void FixedUpdate()
    {
        rb.AddForce(Vector3.down * fallspeed * thrust, ForceMode.Impulse);
    }
}
