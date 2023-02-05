using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

using System.Security.Cryptography;
using UnityEngine;

public class L9task3 : MonoBehaviour
{
	public GameObject player;
	public float posX, posY, posZ;
	public float jump;
	int counter = 0;
	public bool wait;
	// Start is called before the first frame update
	void Start()
	{

		
		// transform.position = player.transform.position - Vector3.forward * 10f;
	}

	// Update is called once per frame
	void Update()
	{
		
		posX = transform.position.x;
		posY = transform.position.y;
		posZ = transform.position.z;
		
		if (counter == 1)
		{
		
		}
		else if (posX > 0 )
		{
			counter = 1;
			transform.position = new Vector3(posX, posY + jump, posZ);
		}
		else {
			if (wait)
				StartCoroutine(waiting());

			transform.position = Vector3.MoveTowards
				(transform.position, player.transform.position, Time.deltaTime);
		}

		
	}
	IEnumerator waiting()
	{
		yield return new WaitForSeconds(1);
	}
}
