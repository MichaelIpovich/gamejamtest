using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    private Transform player;
    
	// Use this for initialization
	void Start ()
	{
		player = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 pos = player.position;
		if (Input.GetAxisRaw("Horizontal") > 1)
		{
			pos.x += 0.5f;
		} else if (Input.GetAxisRaw("Horizontal") < -1)
		{
			pos.x -= 0.5f;
		}
		player.position = pos;
	}
}
