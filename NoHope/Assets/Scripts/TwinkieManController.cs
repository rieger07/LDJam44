using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwinkieManController : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up);
            
            Debug.Log("Up");
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left);
            Debug.Log("left");
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down);
            Debug.Log("down");
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right);
            Debug.Log("right");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up);
            Debug.Log("Up");
        }
    }
}
