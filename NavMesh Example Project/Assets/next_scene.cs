using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class next_scene : MonoBehaviour
{
    

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.name == "Player")
        {
            Debug.Log("enter next scene");
            SceneManager.LoadScene("l5_1");
        }
    }

    void Update()
    {
     
    }

}
