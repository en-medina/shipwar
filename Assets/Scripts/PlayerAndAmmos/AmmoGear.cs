using UnityEngine;
using System.Collections;

public class AmmoGear : MonoBehaviour {

    public float ShootSpeed = 1f;
    public float ShootPower = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.AutoMove(ShootSpeed*-1);
	}

}
