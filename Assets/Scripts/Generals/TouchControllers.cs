using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TouchControllers : MonoBehaviour {
    
   // public KeyCode[] ShootButton = { KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4 };
    //public KeyCode SpecialsButton = KeyCode.Q;
    //public KeyCode SwapButton = KeyCode.W;
    public bool[] Shoot = new bool[4];
    public bool Special;
    public bool Swap;
    
    void Awake()
    {

    }
   
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () 
    {
        
	}
    
    public void OnTouch(int position)
    {
        Shoot[position - 1] = true;
    }
}
