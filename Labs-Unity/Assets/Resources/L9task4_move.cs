
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class L9task4_move : MonoBehaviour
{
    public float speed = 5;
    public float jump;
    private Rigidbody rb;
    public GameObject player= null;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveJump = 0.0f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("a");
            rb.AddForce(new Vector3(0,jump,0), ForceMode.Impulse);

            Color col1 = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
            player.GetComponent<MeshRenderer>().material.color = col1;


        }
        Vector3 movement = new Vector3(moveHorizontal, moveJump, moveVertical);
        rb.AddForce(movement * speed);
    }
}
