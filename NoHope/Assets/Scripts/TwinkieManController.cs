using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinkieManController : MonoBehaviour
{
    // Start is called before the first frame update
    private ILogger l;
    void Start()
    {
        l = GetComponent<Logger>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.up);
            
            l.Log("Up");
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left);
            l.Log("left");
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.down);
            l.Log("left");
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right);
            l.Log("left");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up);
            l.Log("left");
        }
    }
}
