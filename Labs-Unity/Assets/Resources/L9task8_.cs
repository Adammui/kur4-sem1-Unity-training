
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L9task8_ : MonoBehaviour
{
    private float minX, maxX, minZ, maxZ, newX, newZ, newY;
    // Start is called before the first frame update
    void Start()
    {   
        MeshRenderer render = gameObject.GetComponent<MeshRenderer>();
        minX = render.bounds.min.x;
        maxX = render.bounds.max.x;
        minZ = render.bounds.min.z;
        maxZ = render.bounds.max.z;
    }

    // Update is called once per frame
    void Update()
    {
        newX = Random.Range(-9 , 0);//(minX, maxX);
        newZ = Random.Range(-3,-32);//(minZ, maxZ);
        newY = Random.Range(1, 10);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cubb = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubb.transform.position = new Vector3(newX, newY, newZ);
            cubb.AddComponent<Rigidbody>();
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            
            //Create random color
            Color col1 = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1.0f);
            //apply to sphere
            sphere.GetComponent<MeshRenderer>().material.color = col1;

            sphere.transform.position = new Vector3(newX, newY, newZ);
            sphere.AddComponent<Rigidbody>();
        }
    }
}
