using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L10task1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "floor")
            UnityEngine.Debug.Log("Я упал на пол и не могу встать");
        else if ( col.gameObject.name == "wall1" || col.gameObject.name == "wall2")
            UnityEngine.Debug.Log("Я завис на стене");
    }
}
