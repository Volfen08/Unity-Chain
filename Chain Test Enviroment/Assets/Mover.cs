using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float force;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.AddForce(Input.GetAxis("Horizontal") * new Vector3(1, 0, 0) * force);
        rb.AddForce(Input.GetAxis("Vertical") * new Vector3(0,0,1) * force);

        //rb = gameobject.transform.parent.parent.gameObject.GetComponet(Rigidbody);
    }
}
