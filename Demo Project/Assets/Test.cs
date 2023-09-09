using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float upSpeed;
    [SerializeField] private float horizontalSpeed;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up *  upSpeed, ForceMode2D.Impulse);
        }
        
        float horizontalInput = Input.GetAxis("Horizontal");
        if(horizontalInput > 0){
        rb.AddForce(Vector2.right * horizontalSpeed,ForceMode2D.Force);

        }
        else  if(horizontalInput<0){
        rb.AddForce(Vector2.left * horizontalSpeed,ForceMode2D.Force);

        }
    }
}
