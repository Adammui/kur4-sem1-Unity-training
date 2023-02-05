using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L10task2 : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 1000 * Time.deltaTime);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "rot")
        {
            UnityEngine.Debug.Log("a");
            Vector3 movement = new Vector3(1, 0, 0);
            rb.AddForce(movement * 5);
        }
    }
}
