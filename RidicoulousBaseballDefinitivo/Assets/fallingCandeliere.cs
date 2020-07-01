using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingCandeliere : MonoBehaviour
{
    public float fallspeed = 2f;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * fallspeed * Time.deltaTime, Space.World);
        position = transform.position;
    }
}
