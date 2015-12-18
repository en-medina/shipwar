using UnityEngine;
using System.Collections;

public class GoAndRotate : MonoBehaviour {

    public float speed;
    public float rotate;

	void Update () 
    {
        transform.AutoMove(speed);
        transform.AutoRotate(rotate);
	}
}
