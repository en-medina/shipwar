using UnityEngine;
using System.Collections;

public class VolatileOrb : MonoBehaviour {

    //Enemie Variables
   
    public float ShieldPower = 1f;
    public float HealthPower = 1f;
    public int PositionID = 1;

    private float RotationSpeed = 2f;
    private float MoveSpeed = 4f;

    //private Animator animations;


	// Use this for initialization
	void Start () {
       // animations = GameObject.Find("VolatileOrb_Electron_1").GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.AutoMove(MoveSpeed);
        transform.AutoRotate(RotationSpeed);
	}

 

}