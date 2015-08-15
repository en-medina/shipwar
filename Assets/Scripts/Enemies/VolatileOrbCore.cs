using UnityEngine;
using System.Collections;

public class VolatileOrbCore : MonoBehaviour 
{
    public int ElectronAmount;
    public GameObject ElectronPrefab;
    public float MoveSpeed = 4f;


    private float RotationSpeed = 2f;
    private GameObject Electron;

    void Awake() 
    {
        
    }

    void Start()
    {
        //this.gameObject.GetComponent<AmmoHit>().ShieldPower = ElectronAmount * 1.5f;
        CreateOrder();
    }
          
    void FixedUpdate()
    {
        transform.AutoMove(MoveSpeed);
        transform.AutoRotate(RotationSpeed);
    }
    
    void CreateOrder()
    {
        float rotater = 360 / ElectronAmount;
        float size = 0;
        for (int i = 0; i < ElectronAmount; i++)
        {
            Electron = (GameObject)Instantiate(ElectronPrefab, transform.position, transform.rotation);
            Electron.transform.parent = transform;
            Electron.transform.Rotate(0f, 0f, size);
            size += rotater;
        }
    }	
}
