using UnityEngine;
using System.Collections;

public class ShipsGear : MonoBehaviour {

    public Vector3 AmmoStartPosition = new Vector3(0.2f, 0f, 0f);
    public float ShieldPower = 1f;
    public float HealthPower = 1f;
    public int PositionID = 1;
    public float CoolDown = 1f;
    public GameObject AmmoPrefabs;


    private TouchControllers ShipsController;
    private GameObject Ammo;
    private float PreviousShootCoolDown = 0f;
   
    void Awake()
    {
        ShipsController = GameObject.FindGameObjectWithTag(Tags.GameGear).GetComponent<TouchControllers>();
    }

	// Use this for initialization
	void Start () 
    {
        PreviousShootCoolDown = 0f;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (ShipsController.Shoot[PositionID - 1] && PreviousShootCoolDown <= 0)
        {
            ShipsController.Shoot[PositionID - 1] = false;
            Shoot();
        }
        if (PreviousShootCoolDown > 0)
            PreviousShootCoolDown -= Time.deltaTime;
	}

    void Shoot()
    {
        Ammo = (GameObject)Instantiate(AmmoPrefabs, transform.position, transform.rotation);
        Ammo.transform.parent = transform;
        Ammo.transform.position = AmmoStartPosition + transform.position;
        PreviousShootCoolDown = CoolDown;
    }
}
