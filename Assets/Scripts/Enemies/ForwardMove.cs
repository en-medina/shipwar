using UnityEngine;
using System.Collections;

public class ForwardMove : MonoBehaviour  
{

    public float speed;
	// Update is called once per frame
	void FixedUpdate () 
    {
        transform.AutoMove(speed);
	}
}
