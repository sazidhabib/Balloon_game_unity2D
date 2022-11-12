using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public float Speed;
    //public float Movement;
    //public float forwardForce = 20f;

    Rigidbody2D rb;
    public float fowardSpeed = 1f;
    public float upSpeed = 100f;

    bool Press = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Press = true;
        }
        else
        {
            Press = false;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(fowardSpeed * Time.deltaTime, 0));
        if (Press == true) {
            rb.AddForce(new Vector2(0, upSpeed * Time.deltaTime));
        }
        //velocity.x = fowardSpeed;
        //transform.position += velocity * Time.deltaTime;
        //if (Press == true)
        //{

        //float Move = playerSpeed * Time.deltaTime;
        //transform.Translate(Vector3.up * Move);
        //}

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Work!");
        if (collision.tag == "spyke")
        {
            Destroy(gameObject);

        }
    }
   
}
