using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void OnCollisionEnter(Collision otherCollider)
        {
        
            Debug.Log("collisione rilevata con l`oggetto");
        Destroy(otherCollider.gameObject);
        }
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
