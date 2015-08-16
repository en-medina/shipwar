using UnityEngine;
using System.Collections;

public class AmmoHit : MonoBehaviour {

    public float ShieldPower = 1f;
    
    private AmmoGear Ammo;
    private SpriteRenderer PowerPerception;
    void Awake()
    {
        PowerPerception = this.gameObject.GetComponent<SpriteRenderer>();
    }

	// Update is called once per frame
	void Update () 
    {
	    if (ShieldPower <= 0)
        {
            Destroy(this.gameObject);
        }
        //PowerPerception.color = Color.Lerp(Color.white, Color.red, 11111f );
	}
    void OnTriggerEnter2D(Collider2D TheyHitMe)
    {
        if(TheyHitMe.tag==Tags.AmmoCollector)
        {
            Debug.Log("Here");
            Ammo = TheyHitMe.GetComponent<AmmoGear>();
            ShieldPower -= Ammo.ShootPower;
            Destroy(TheyHitMe.gameObject);
        }
    }
}
